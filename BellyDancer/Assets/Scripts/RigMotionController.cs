using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigMotionController : MonoBehaviour
{
    public int mouseDistance=3;
    public GameObject followRig;
    public GameObject RigFollowToCharacter;
    public bool onMouseDrag = false;
    

    // Start is called before the first frame update
    void Start()
    {
        
    } 

    // Update is called once per frame
    void Update()
    {
        this.transform.position = RigFollowToCharacter.transform.position;
        
    }

    public void OnMouseDrag()
    {    onMouseDrag = true;
        
        if (onMouseDrag == true)
        {
            print("mousedrag");
            Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, mouseDistance));
            this.transform.position = pos;
            followRig.transform.position = this.transform.position;
            
        }
        
    }
   
   
    private void OnMouseUp()
    {
        print("mouse býraktý");
        onMouseDrag = false;
    }









}
