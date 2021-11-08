using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFollowToMixamo : MonoBehaviour
{
    public RigMotionController rig_motion_cont;
    public GameObject mixamoAll;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rig_motion_cont.onMouseDrag == false)
        {
            this.transform.position = mixamoAll.transform.position;
        }
        
    }
}
