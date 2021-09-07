using UnityEngine;

public class PlayerHandling2 : MonoBehaviour
{
    public Camera secondCamera;
    public Camera firstCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SecondView();
        player2Handling();
    }

    void player2Handling()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime);
        }
    }

    void SecondView()
    {
        if (Input.GetKey(KeyCode.Alpha2))
        {
            secondCamera.enabled = true;
            firstCamera.enabled = false;
        }
    }
}
