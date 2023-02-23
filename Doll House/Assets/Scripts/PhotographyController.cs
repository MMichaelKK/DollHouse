using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotographyController : MonoBehaviour
{
    public int numberOfFlashes;
    int flashesTaken = 0;
    public Material mat;
    public Image test;
    Texture2D capture;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) {
            if (numberOfFlashes > flashesTaken)
            {
                RaycastHit hit;
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, Mathf.Infinity))
                {
                    if (hit.collider.tag == "CameraPlate")
                    {
                        //add picuture to polarod
                        Debug.Log("'Picture'");
                        flashesTaken++;
                        test.enabled = true;
                        Rect regionToRead = new Rect(0, 0, Screen.width, Screen.height);
                        capture.ReadPixels(regionToRead, 0, 0, false);
                        //capture.Apply();
                        Sprite photoSprite = Sprite.Create(capture, new Rect(0.0f,0.0f,capture.width,capture.height), new Vector2(0.5f,0.5f),100.0f);
                        test.sprite = photoSprite;
                    }
                    else if (hit.collider.tag == "Carrie" || hit.collider.tag == "Rune")
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