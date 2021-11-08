using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerControls : MonoBehaviour
{

    // TARGETLER ELLER� KOLLARI TAK�P ETM�YOR ONU TAK�P ETT�RMEM�Z LAZIM . 
    public MainCharacterControl main_character_control; //maincharacter scriptine eri�mek i�in tan�mlad���m de�i�ken
    public BoolControls boolean_controls; //boolcontrols scriptine eri�mek i�in de�i�ken tan�mlad�m
    public GameObject particleEffects; //��kacak particle i�in 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {//TR�GGERLAR KONTROL ED�L�R VE AN�MASYONLAR BA�LAR + W�EGHTLER� KAPATIRIZ 


        //�LK AN�MASYONDA �IKACAK TR�GGERLAR TET�KLEND�KTEN SONRA BOOLAR TRUE OLACAK.
        if (other.tag == "LeftHand")
        {
            GameObject obj = Instantiate(particleEffects, this.transform.position, Quaternion.identity);
            print("�arp��t�LeftHand");
            boolean_controls.leftHand = true;
            main_character_control.AtTheEndOfTheFirstAnimation();
        }
        if (other.tag == "RightHand")
        {
            GameObject obj = Instantiate(particleEffects, this.transform.position, Quaternion.identity);
            boolean_controls.RightHand = true;
            main_character_control.AtTheEndOfTheFirstAnimation();
            print("�arp��t�RightHand");
        }
        if (other.tag == "LeftFoot")
        {
            GameObject obj = Instantiate(particleEffects, this.transform.position, Quaternion.identity);
            boolean_controls.leftFoot = true;
            main_character_control.AtTheEndOfTheFirstAnimation();
            print("�arp��t�LeftFoot");
        }
        if (other.tag == "RightFoot")
        {
            GameObject obj = Instantiate(particleEffects, this.transform.position, Quaternion.identity);
            boolean_controls.RightFoot = true;
            main_character_control.AtTheEndOfTheFirstAnimation();
            print("�arp��t�RightFoot");
        }
        if (other.tag == "Head")
        {
            GameObject obj = Instantiate(particleEffects, this.transform.position, Quaternion.identity);
            boolean_controls.RightHand = true;
            main_character_control.AtTheEndOfTheFirstAnimation();
            print("�arp��t�head");
        }

        //�K�NC� AN�MASYONDAN SONRA �IKACAK TR�GGERLAR TET�KLEN�NCE BOOLLAR TRUE OLACAK

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
