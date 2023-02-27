using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotographyController : MonoBehaviour
{
    public int numberOfFlashes;
    int flashesTaken = -1;
    public Image[] displayImages;
    public Image[] corespondingImages;
    Texture2D capture;
    // Start is called before the first frame update
    void Start()
    {
        capture = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false); ;
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
                        Debug.Log("'Picture'");
                        flashesTaken++;
                        displayImages[flashesTaken].gameObject.SetActive(true);
                        corespondingImages[flashesTaken].gameObject.SetActive(true);
                        StartCoroutine(CapturePhoto());
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

    IEnumerator CapturePhoto() {
        yield return new WaitForEndOfFrame();
        Rect regionToRead = new Rect(0, 0, Screen.width, Screen.height);
        capture.ReadPixels(regionToRead, 0, 0, false);
        capture.Apply();
        showPhoto();
    }

    void showPhoto() {
        Sprite photoSprite = Sprite.Create(capture, new Rect(0.0f, 0.0f, capture.width, capture.height), new Vector2(0.5f, 0.5f), 100.0f);
        displayImages[flashesTaken].sprite = photoSprite;
    }
}