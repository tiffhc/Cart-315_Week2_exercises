using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build : MonoBehaviour
{
    public GameObject thecamera;
    public GameObject create;

    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate() // 60 times per second
    {
        count = count + 1;
        if (count >= 3) count = 0; //hold the right button, every 3 update. Only execute this code when it's count == 0 
        if (Input.GetMouseButton(1) && count == 0) //input button 1, 0 left click
        {
            //to study
            RaycastHit hit;
            Ray ray = thecamera.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                GameObject.Instantiate(create, hit.point, Quaternion.identity); //no rotation
            }
        }
    }
}
