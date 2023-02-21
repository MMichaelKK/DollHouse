using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotographyController : MonoBehaviour
{
    public int numberOfFlashes;
    int flashesTaken = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F)) {
            if (numberOfFlashes >= flashesTaken)
            {
                RaycastHit hit;
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
                {
                    if (hit.collider.tag == "CameraPlate")
                    {
                        //add picuture to polarod
                        flashesTaken++;
                    }
                    else if (hit.collider.tag == "Carrie")
                    {
                        //add all dolls tags to if statement
                        //send message to doll to do something
                        flashesTaken++;
                    }
                    else
                    {
                        //flash
                        flashesTaken++;
                    }
                }
            }
        }
    }
}
