using UnityEngine;

public class PlayerHandling1 : MonoBehaviour
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
        FirstView();
        player1Handling();
    }

    void player1Handling()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-10f, 0f, 0f) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(10f, 0f, 0f) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0f, 0f, 10f) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0f, 0f, -10f) * Time.deltaTime);
        }
    }

    void FirstView()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            firstCamera.enabled = true;
            secondCamera.enabled = false;
        }
    }
}
