using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//when player enters the zone, make them bounce

public class bounce : MonoBehaviour
{
    public GameObject the_other_object; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        //this.GetComponent<Rotate> - dont add a component that is not there. Missing rotate script. 
        if(other.gameObject == the_other_object)
        {
            other.GetComponent<Rigidbody>().AddForce(0, 500.0f * Time.deltaTime, 0);
        }
        //every update that the object is inside the trigger zone, it adds an upward force
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == the_other_object) //refer to the game object of the collider, now only the object with audio is affected
        {
            other.GetComponent<AudioSource>().Play();
        }
        
    }
    //on trigger entering, Unity will look for on anything that has a trigger. 
    //private void OnTriggerEnter(Collider other) //other is what is being collided with it?
    // {
    //how to access rigid body component
    //other.GetComponent<Rigidbody>().AddForce(0, 700.0f, 0); //call the get component method on rigid body of that component
    // }
}
