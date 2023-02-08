using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public float speed = 0f;
    public float Rspeed = 0f;
    public GameObject camera;
    float mosPosX;
    float newMosPosX;
    Vector3 mousePos;
    Transform cameratransform;
    // Start is called before the first frame update
    void Start()
    {
        mousePos = Input.mousePosition;
        mosPosX = mousePos.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.S)){
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A)) {
            transform.Rotate(Vector3.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.right * speed * Time.deltaTime);
        }
        //mousePos = Input.mousePosition;
        //newMosPosX = mousePos.x;
        //cameratransform.Rotate(Rspeed * Time.deltaTime * new Vector3((mosPosX - newMosPosX),0, 0));
       // mosPosX = newMosPosX;

    }
}
