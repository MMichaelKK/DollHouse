using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public float speed = 0f;
    public float Rspeed = 0f;
    float xRotation = 0f;
    float yRotation = 0f;
    public Transform playerBody;
    public Transform camera;

    //Debug testing 
    public DollMover dollmoverS;
    public GameObject Carrie;
    public GameObject Rune;
    // 

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
        }
        //Debug testing
        else if (Input.GetKey(KeyCode.J)) {
            dollmoverS.move(Carrie, "Kitchen");
        }
        else if (Input.GetKey(KeyCode.K)) {
            dollmoverS.moveRandomLocation(Rune);
        }
        else if (Input.GetKey(KeyCode.L)) {
            dollmoverS.moveRandom();
        }
        // 

        float mouseX = Input.GetAxis("Mouse X") * Rspeed * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * Rspeed * Time.deltaTime;
        xRotation += mouseX;
        yRotation -= mouseY;
        yRotation = Mathf.Clamp(yRotation, -40f,40f);
        transform.localRotation = Quaternion.Euler(0f, xRotation, 0f);
        camera.localRotation = Quaternion.Euler(yRotation, 0f, 0f);
        camera.Rotate(Vector3.right * mouseY);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}