using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class MainCharacterControl : MonoBehaviour
{
    public GameObject firstAnim; //ÝLK ANÝMASYON
    public GameObject SecondAnim; //ÝKÝNCÝ ANÝMASYON
    public GameObject firstTriggerObjects; // ÝLK TRÝGGER OBJELERÝ
    public GameObject secondTriggerObjects; // ÝKÝNCÝ TRÝGGER OBJELERÝ
    public GameObject circle; //Dairelerin çýkýp çýkmayacaðýna karar vermek için.

    //ELLERÝN KOLLARIN HARAKETÝNÝ ETKÝNLEÞTÝRMEK ÝÇÝN
    public GameObject weightLeftHand;
    public GameObject weightLeftFoot;
    public GameObject weightRightFoot;
    public GameObject weightRightHand;
    public GameObject weightHead;

    
    public Animator AnimController; //ANÝMASYON ÇALIÞTIRMASI ÝÇÝN VE GEÇÝÞLER ÝÇÝN

    public BoolControls boolean; //boolcontrols scriptine eriþmek için deðiþken tanýmladým

    public GameObject amazingTextGameobje; //amazing yazýsý çýkmasýný saðlayan gameobject

    public GameObject loseSceneGameobje; //lose yazýsý animasyonunu etkinleþtiren gameobje
    IEnumerator co;
    // Start is called before the first frame update
    void Start()
    {
        co = THEYWILLBEAFTER13SECONDS();
        StartCoroutine(TimeToStartThefirstAnimation());
        StartCoroutine(THEYWILLBEAFTER13SECONDS());
        StartCoroutine(FirstTriggerObjectSecond());
        StartCoroutine(THEYWILLBESCONDAFTER18SECONDS());
    }

    // Update is called once per frame
    void Update()
    {
        asd();
    }
    void asd()
    {
        if (AnimController.GetBool("FirstAllTriggers") == true)
        {
            StartCoroutine(TimeToStartTheSecondAnimation());
            StartCoroutine(SecondTriggerObjectSecond());
        }
       
    }
    IEnumerator FirstTriggerObjectSecond()
    {
        yield return new WaitForSeconds(1f);
        firstTriggerObjects.SetActive(true);
        
    }
    IEnumerator SecondTriggerObjectSecond()
    {
        yield return new WaitForSeconds(7f);
        secondTriggerObjects.SetActive(true);
    }
    IEnumerator TimeToStartThefirstAnimation()
    {//ilk animasyon için beklenecek süre geçtikten sonra ilk animasyonu baþlatýyor + ilk triggirlanacak objeleri açýyor + riglerin weightlerini 1 yapýyor.
        yield return new WaitForSeconds(3f);
        print("3sn geçti");
        firstAnim.SetActive(true);
        
        circle.SetActive(true);
        AnimController.speed = 0;
        weightHead.GetComponent<MultiAimConstraint>().weight = 1;
        weightRightHand.GetComponent<TwoBoneIKConstraint>().weight = 1;
        weightLeftHand.GetComponent<TwoBoneIKConstraint>().weight = 1;
        weightRightFoot.GetComponent<TwoBoneIKConstraint>().weight = 1;
        weightLeftFoot.GetComponent<TwoBoneIKConstraint>().weight = 1;
    }

    IEnumerator TimeToStartTheSecondAnimation()
    {
        //ikinci animasyon için beklenecek süre geçtikten sonra ikinci animasyonu baþlatýyor + ikinci triggirlanacak objeleri açýyor + riglerin weightlerini 1 yapýyor.
        yield return new WaitForSeconds(6f);
        print("3sn geçti");
        SecondAnim.SetActive(true);
        
        circle.SetActive(true);
        AnimController.speed = 0;
        weightHead.GetComponent<MultiAimConstraint>().weight = 1;
        weightRightHand.GetComponent<TwoBoneIKConstraint>().weight = 1;
        weightLeftHand.GetComponent<TwoBoneIKConstraint>().weight = 1;
        weightRightFoot.GetComponent<TwoBoneIKConstraint>().weight = 1;
        weightLeftFoot.GetComponent<TwoBoneIKConstraint>().weight = 1;
    }

    public void AtTheEndOfTheFirstAnimation()
    {
        if (boolean.firstContorl == true && boolean.RightFoot == true && boolean.RightHand == true && boolean.leftFoot == true && boolean.RightHand == true && boolean.leftHand == true)
        {
                boolean.firstContorl = false;
                StartCoroutine(MakeHeartEyeAndAmazingFalse());
                amazingTextGameobje.SetActive(true);
                //StopCoroutine(co); //coroutine durdurmak için startda da tanýmladýðým co fonksiyonunu çaðýrdým ancak çalýþmadý.
                StartCoroutine(activeSeconds());
                AnimController.speed = 1;
                weightHead.GetComponent<MultiAimConstraint>().weight = 0;
                weightRightHand.GetComponent<TwoBoneIKConstraint>().weight = 0;
                weightLeftHand.GetComponent<TwoBoneIKConstraint>().weight = 0;
                weightRightFoot.GetComponent<TwoBoneIKConstraint>().weight = 0;
                weightLeftFoot.GetComponent<TwoBoneIKConstraint>().weight = 0;
                AnimController.SetBool("FirstAllTriggers", true);
                boolean.firstContorl = false;
                boolean.fallAnim = false;
                boolean.RightFoot = false;
                boolean.RightHand = false;
                boolean.leftFoot = false;
                boolean.RightHand = false;
                boolean.leftHand = false;
        }
        else if (boolean.firstContorl == true &&(boolean.RightFoot == false || boolean.RightHand == false || boolean.leftFoot == false || boolean.RightHand == false || boolean.leftHand == false))
        {
            
            boolean.fallAnim = true;
        }
    }
    public void AtTheEndOfTheSecondAnimation()
    {
        if (boolean.secondControl == true && boolean.secondBoolRightFoot == true && boolean.secondBoolRightHand == true && boolean.secondBoolLeftFoot == true && boolean.secondBoolRightHand == true && boolean.secondBoolLeftHand == true)
        {
            print("girdi");
            boolean.secondControl = false;
            StartCoroutine(SecondMakeHeartEyeAndAmazingFalse());
            amazingTextGameobje.SetActive(true);
            //StopCoroutine(co); //coroutine durdurmak için startda da tanýmladýðým co fonksiyonunu çaðýrdým ancak çalýþmadý.
            SecondAnim.SetActive(false);
            print("çalýþtý");
            secondTriggerObjects.SetActive(false);
            circle.SetActive(false);
            AnimController.speed = 1;
            AnimController.SetBool("SecondAllTriggers", true);
            weightHead.GetComponent<MultiAimConstraint>().weight = 0;
            weightRightHand.GetComponent<TwoBoneIKConstraint>().weight = 0;
            weightLeftHand.GetComponent<TwoBoneIKConstraint>().weight = 0;
            weightRightFoot.GetComponent<TwoBoneIKConstraint>().weight = 0;
            weightLeftFoot.GetComponent<TwoBoneIKConstraint>().weight = 0;
            boolean.secondBoolfallAnim = false;
            

        }
        //else if (SecondAnim == true && (boolean.secondBoolRightFoot == false || boolean.secondBoolRightHand == false || boolean.secondBoolLeftFoot == false || boolean.secondBoolRightHand == false || boolean.secondBoolLeftHand == false))
        //{
        //    boolean.secondBoolfallAnim = true;
        //}
    }

    IEnumerator THEYWILLBEAFTER13SECONDS()
    {
        yield return new WaitForSeconds(13.1f);
        
        //triggerlarýn hepsi true olmazsa fallanim true olucak ve düþme animasyonuna geçicek
        if (boolean.fallAnim ==true)
        {
            loseSceneGameobje.SetActive(true);
            
            AnimController.speed = 1;
            firstAnim.SetActive(false);
            firstTriggerObjects.SetActive(false);
            circle.SetActive(false);
            weightHead.GetComponent<MultiAimConstraint>().weight = 0;
            weightRightHand.GetComponent<TwoBoneIKConstraint>().weight = 0;
            weightLeftHand.GetComponent<TwoBoneIKConstraint>().weight = 0;
            weightRightFoot.GetComponent<TwoBoneIKConstraint>().weight = 0;
            weightLeftFoot.GetComponent<TwoBoneIKConstraint>().weight = 0;
            AnimController.SetBool("Fall", true);

        }
    }
    IEnumerator THEYWILLBESCONDAFTER18SECONDS()
    {
        yield return new WaitForSeconds(18.1f);

        //triggerlarýn hepsi true olmazsa fallanim true olucak ve düþme animasyonuna geçicek
        if (boolean.secondBoolfallAnim == true)
        {
            loseSceneGameobje.SetActive(true);

            AnimController.speed = 1;
            SecondAnim.SetActive(false);
            secondTriggerObjects.SetActive(false);
            circle.SetActive(false);
            weightHead.GetComponent<MultiAimConstraint>().weight = 0;
            weightRightHand.GetComponent<TwoBoneIKConstraint>().weight = 0;
            weightLeftHand.GetComponent<TwoBoneIKConstraint>().weight = 0;
            weightRightFoot.GetComponent<TwoBoneIKConstraint>().weight = 0;
            weightLeftFoot.GetComponent<TwoBoneIKConstraint>().weight = 0;
            AnimController.SetBool("Fall", true);

        }
    }
    IEnumerator MakeHeartEyeAndAmazingFalse() //KALPLÝ GÖZ VE AMAZÝNG YAZISINI 1.5 SANÝYE SONRA FALSE OLAMSINI SAÐLAYACAK BÖYLECE EKRANDA ÇOK ÇIKMAYACAK
    {
        yield return new WaitForSeconds(1f);
        amazingTextGameobje.SetActive(false);
    }
    IEnumerator SecondMakeHeartEyeAndAmazingFalse() //ÝKÝNCÝ KALPLÝ GÖZ VE AMAZÝNG YAZISINI 1.5 SANÝYE SONRA FALSE OLAMSINI SAÐLAYACAK BÖYLECE EKRANDA ÇOK ÇIKMAYACAK
    {
        yield return new WaitForSeconds(1f);
        amazingTextGameobje.SetActive(false);
    }
    
    IEnumerator activeSeconds()
    {
        yield return new WaitForSeconds(0.2f);
        firstAnim.SetActive(false);
        firstTriggerObjects.SetActive(false);
        circle.SetActive(false);
    }
}
