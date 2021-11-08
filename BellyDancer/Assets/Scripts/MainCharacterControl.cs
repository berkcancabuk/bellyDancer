using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class MainCharacterControl : MonoBehaviour
{
    public GameObject firstAnim; //�LK AN�MASYON
    public GameObject SecondAnim; //�K�NC� AN�MASYON
    public GameObject firstTriggerObjects; // �LK TR�GGER OBJELER�
    public GameObject secondTriggerObjects; // �K�NC� TR�GGER OBJELER�
    public GameObject circle; //Dairelerin ��k�p ��kmayaca��na karar vermek i�in.

    //ELLER�N KOLLARIN HARAKET�N� ETK�NLE�T�RMEK ���N
    public GameObject weightLeftHand;
    public GameObject weightLeftFoot;
    public GameObject weightRightFoot;
    public GameObject weightRightHand;
    public GameObject weightHead;

    
    public Animator AnimController; //AN�MASYON �ALI�TIRMASI ���N VE GE���LER ���N

    public BoolControls boolean; //boolcontrols scriptine eri�mek i�in de�i�ken tan�mlad�m

    public GameObject amazingTextGameobje; //amazing yaz�s� ��kmas�n� sa�layan gameobject

    public GameObject loseSceneGameobje; //lose yaz�s� animasyonunu etkinle�tiren gameobje
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
    {//ilk animasyon i�in beklenecek s�re ge�tikten sonra ilk animasyonu ba�lat�yor + ilk triggirlanacak objeleri a��yor + riglerin weightlerini 1 yap�yor.
        yield return new WaitForSeconds(3f);
        print("3sn ge�ti");
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
        //ikinci animasyon i�in beklenecek s�re ge�tikten sonra ikinci animasyonu ba�lat�yor + ikinci triggirlanacak objeleri a��yor + riglerin weightlerini 1 yap�yor.
        yield return new WaitForSeconds(6f);
        print("3sn ge�ti");
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
                //StopCoroutine(co); //coroutine durdurmak i�in startda da tan�mlad���m co fonksiyonunu �a��rd�m ancak �al��mad�.
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
            //StopCoroutine(co); //coroutine durdurmak i�in startda da tan�mlad���m co fonksiyonunu �a��rd�m ancak �al��mad�.
            SecondAnim.SetActive(false);
            print("�al��t�");
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
        
        //triggerlar�n hepsi true olmazsa fallanim true olucak ve d��me animasyonuna ge�icek
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

        //triggerlar�n hepsi true olmazsa fallanim true olucak ve d��me animasyonuna ge�icek
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
    IEnumerator MakeHeartEyeAndAmazingFalse() //KALPL� G�Z VE AMAZ�NG YAZISINI 1.5 SAN�YE SONRA FALSE OLAMSINI SA�LAYACAK B�YLECE EKRANDA �OK �IKMAYACAK
    {
        yield return new WaitForSeconds(1f);
        amazingTextGameobje.SetActive(false);
    }
    IEnumerator SecondMakeHeartEyeAndAmazingFalse() //�K�NC� KALPL� G�Z VE AMAZ�NG YAZISINI 1.5 SAN�YE SONRA FALSE OLAMSINI SA�LAYACAK B�YLECE EKRANDA �OK �IKMAYACAK
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
