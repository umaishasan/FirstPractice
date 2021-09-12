using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject ball;
    public GameObject cameraa;
    public Vector3 movTopos;
    private float speed = 0.6f;

    void Update()
    {
        movementSlowly();
    }

    public void movementSlowly()
    {
        //movTopos = ball.transform.position;
        movTopos = ball.transform.position;
        float stepss = speed * Time.deltaTime;
        cameraa.transform.localPosition = Vector3.Lerp(cameraa.transform.position, movTopos, stepss);
        Debug.Log("movement slowly method call");
    }
}
