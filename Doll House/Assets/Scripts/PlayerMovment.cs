using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public float speed = 0f;
    public float Rspeed = 0f;
    float mosPosX;
    float newMosPosX;
    Vector3 mousePos;
    public GameObject camera;
    Transform cameratransform;
    // Start is called before the first frame update
    void Start()
    {
        cameratransform = camera.transform;
        mousePos = Input.mousePosition;
        mosPosX = mousePos.x;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
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
        mousePos = Input.mousePosition;
        newMosPosX = mousePos.x;
        transform.Rotate(Rspeed * Time.deltaTime * new Vector3(0, (mosPosX - newMosPosX), 0));
        mosPosX = newMosPosX;
        Cursor.lockState = CursorLockMode.Locked;

    }
}
