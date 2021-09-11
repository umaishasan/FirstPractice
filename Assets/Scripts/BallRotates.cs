using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRotates : MonoBehaviour
{
    public GameObject ball;
    public GameObject cameraa;
    public bool stopBalling;
    public Vector3 movTopos;
    private float speed = 0.6f;

    void Update()
    {
        if(stopBalling)
        {
            ballRoatating();
        }
    }

    void OnMouseDown()
    {
        movTopos = ball.transform.localPosition;
        stopBalling = false;
        movementSlowly();
        Debug.Log(ball.transform.localPosition+"ball stop");

        //StartCoroutine(cameraFocusing());
    }

    void ballRoatating()
    {
        ball.transform.Rotate(new Vector3(0, 2, 0) * 2);
        Debug.Log("ball rotate");
    }

    void movementSlowly()
    {
        float stepss = speed*Time.deltaTime;
        cameraa.transform.position = Vector3.Lerp(cameraa.transform.position, movTopos, stepss);
    }

    /*    IEnumerator cameraFocusing()
        {
            yield return new WaitUntil(()=>Input.GetMouseButtonDown(0));
            movementSlowly();
            Debug.Log("Camera Focusing");
        }*/
}
