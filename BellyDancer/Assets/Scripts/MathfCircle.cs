using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathfCircle : MonoBehaviour
{
    public GameObject mathfLeftHandCircle;
    public GameObject mathfRightHandCircle;
    public GameObject mathfLeftFootCircle;
    public GameObject mathfRightFootCircle;
    public GameObject mathfChestCircle;
    public GameObject mathfHeadCircle;
  
    
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        matfFunction();
    }

    public void matfFunction()
    {
        
        Vector3 lefthand = new Vector3(Mathf.Clamp(mathfLeftHandCircle.transform.position.x, -0.638f, -0.277774f), Mathf.Clamp(mathfLeftHandCircle.transform.position.y, 0.94845f, 1.7f), 0.03700f);
        Vector3 righthand = new Vector3(Mathf.Clamp(mathfRightHandCircle.transform.position.x, 0.272f, 0.643f), Mathf.Clamp(mathfRightHandCircle.transform.position.y, 0.909f, 1.651f), 0.03700f);
        Vector3 head = new Vector3(Mathf.Clamp(mathfHeadCircle.transform.position.x,-0.11383f,0.11383f), Mathf.Clamp(mathfHeadCircle.transform.position.y, 1.49f, 1.59f), 0.03700f);
        Vector3 rightfoot = new Vector3(Mathf.Clamp(mathfRightFootCircle.transform.position.x, -0.09137f, 0.27f), Mathf.Clamp(mathfRightFootCircle.transform.position.y, 0.09428f, 0.111f), 0.03700f);
        Vector3 leftfoot = new Vector3(Mathf.Clamp(mathfLeftFootCircle.transform.position.x, -0.347f, -0.114f), Mathf.Clamp(mathfLeftFootCircle.transform.position.y, 0.092f, 0.114f), 0.03700f);

        mathfLeftHandCircle.transform.position = lefthand;
        mathfRightHandCircle.transform.position = righthand;
        mathfHeadCircle.transform.position = head;
        mathfLeftFootCircle.transform.position = leftfoot;
        mathfRightFootCircle.transform.position = rightfoot;
    }
}
