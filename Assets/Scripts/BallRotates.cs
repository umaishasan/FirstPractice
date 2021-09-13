using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRotates : MonoBehaviour
{
    public bool stopBalling;
    public float startTime;

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
        gameObject.GetComponent<CameraFollow>().enabled = true;
        this.startTime = Time.timeScale = 2.30365f;
        Debug.Log("time call from ball rotate class"+ startTime);
    }

    void ballRoatating()
    {
        gameObject.transform.Rotate(new Vector3(0, 2, 0) * 2);
    }
}
