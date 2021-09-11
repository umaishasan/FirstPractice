using UnityEngine;

public class TranslatePosition : MonoBehaviour
{
    private float speed = 10f;
    public Rigidbody rigidbody;

    void Start()
    {
        /*rigidbody = gameObject.GetComponent<Rigidbody>();*/
        rigidbody.useGravity = false;
        Debug.Log("Start called");
    }

    void Update()
    {
        this.objectMovingWithDT();
    }

    void objectMovingWithDT()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.down * speed);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * speed);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0f, -10f, 0f) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0f, 10f, 0f) * Time.deltaTime);
        }

        /*else if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0f, 0f, 10f) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0f, 0f, -10f) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * speed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back * speed);
        }*/

    }
}