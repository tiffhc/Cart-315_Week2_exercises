using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//default import 

 //public class is accessable. 
public class Rotate : MonoBehaviour //rotate is a subclass of MonoBehaviour (class of all components) a lot of things we don't need to do
{
    public float rotate_speed = 0.1f; 

    // Start is called before the first frame update
    //void do stuff without returnning anything, unity will run this function 
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //eulers - x, y, and z
        if (Input.GetButton("Fire1"))
        {
            this.transform.Rotate(0.0f, rotate_speed, 0.0f);
        }

    }
}
