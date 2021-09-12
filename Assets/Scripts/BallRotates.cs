using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRotates : MonoBehaviour
{
    public bool stopBalling;
    public CameraFollow cf;

    void Update()
    {
        if(stopBalling)
        {
            ballRoatating();
        }
    }

    void OnMouseDown()
    {
        stopBalling = false;
        Debug.Log("ball stop");
        gameObject.GetComponent<CameraFollow>().enabled = true;
        Debug.Log("Script call");
    }

    void ballRoatating()
    {
        gameObject.transform.Rotate(new Vector3(0, 2, 0) * 2);
        Debug.Log("ball rotate");
    }

    /*IEnumerator cameraFocusing()
    {
        yield return new WaitUntil(() => Input.GetMouseButtonDown(1));
        movementSlowly();
        Debug.Log("Camera Focusing");
    }*/
}
