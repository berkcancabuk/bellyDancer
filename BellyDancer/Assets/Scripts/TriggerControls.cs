using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerControls : MonoBehaviour
{

    // TARGETLER ELLERÝ KOLLARI TAKÝP ETMÝYOR ONU TAKÝP ETTÝRMEMÝZ LAZIM . 
    public MainCharacterControl main_character_control; //maincharacter scriptine eriþmek için tanýmladýðým deðiþken
    public BoolControls boolean_controls; //boolcontrols scriptine eriþmek için deðiþken tanýmladým
    public GameObject particleEffects; //çýkacak particle için 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {//TRÝGGERLAR KONTROL EDÝLÝR VE ANÝMASYONLAR BAÞLAR + WÝEGHTLERÝ KAPATIRIZ 


        //ÝLK ANÝMASYONDA ÇIKACAK TRÝGGERLAR TETÝKLENDÝKTEN SONRA BOOLAR TRUE OLACAK.
        if (other.tag == "LeftHand")
        {
            GameObject obj = Instantiate(particleEffects, this.transform.position, Quaternion.identity);
            print("çarpýþtýLeftHand");
            boolean_controls.leftHand = true;
            main_character_control.AtTheEndOfTheFirstAnimation();
        }
        if (other.tag == "RightHand")
        {
            GameObject obj = Instantiate(particleEffects, this.transform.position, Quaternion.identity);
            boolean_controls.RightHand = true;
            main_character_control.AtTheEndOfTheFirstAnimation();
            print("çarpýþtýRightHand");
        }
        if (other.tag == "LeftFoot")
        {
            GameObject obj = Instantiate(particleEffects, this.transform.position, Quaternion.identity);
            boolean_controls.leftFoot = true;
            main_character_control.AtTheEndOfTheFirstAnimation();
            print("çarpýþtýLeftFoot");
        }
        if (other.tag == "RightFoot")
        {
            GameObject obj = Instantiate(particleEffects, this.transform.position, Quaternion.identity);
            boolean_controls.RightFoot = true;
            main_character_control.AtTheEndOfTheFirstAnimation();
            print("çarpýþtýRightFoot");
        }
        if (other.tag == "Head")
        {
            GameObject obj = Instantiate(particleEffects, this.transform.position, Quaternion.identity);
            boolean_controls.RightHand = true;
            main_character_control.AtTheEndOfTheFirstAnimation();
            print("çarpýþtýhead");
        }

        //ÝKÝNCÝ ANÝMASYONDAN SONRA ÇIKACAK TRÝGGERLAR TETÝKLENÝNCE BOOLLAR TRUE OLACAK

        if (other.tag == "SecondLeftHand")
        {
            GameObject obj = Instantiate(particleEffects, this.transform.position, Quaternion.identity);
            print("SecondLeftHand");
            boolean_controls.secondBoolLeftHand = true;
            main_character_control.AtTheEndOfTheSecondAnimation();
        }
        if (other.tag == "SecondRightHand")
        {
            GameObject obj = Instantiate(particleEffects, this.transform.position, Quaternion.identity);
            print("SecondRightHand");
            boolean_controls.secondBoolRightHand = true;
            main_character_control.AtTheEndOfTheSecondAnimation();
            
        }
        if (other.tag == "SecondLeftFoot")
        {
            GameObject obj = Instantiate(particleEffects, this.transform.position, Quaternion.identity);
            print("SecondLeftFoot");
            boolean_controls.secondBoolLeftFoot = true;
            main_character_control.AtTheEndOfTheSecondAnimation();
           
        }
        if (other.tag == "SecondRightFoot")
        {
            GameObject obj = Instantiate(particleEffects, this.transform.position, Quaternion.identity);
            print("SecondRightFoot");
            boolean_controls.secondBoolRightFoot = true;
            main_character_control.AtTheEndOfTheSecondAnimation();
            
        }
        if (other.tag == "SecondHead")
        {
            GameObject obj = Instantiate(particleEffects, this.transform.position, Quaternion.identity);
            print("SecondHead");
            boolean_controls.secondBoolHead = true;
            main_character_control.AtTheEndOfTheSecondAnimation();
           
        }
    }
}
