using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject ball;
    public GameObject cameraa;
    BallRotates br = new BallRotates();

    void Update()
    {
         movementSlowly();
        // movementWithoutLerp();
    }

    public void movementSlowly()
    {
        float timecover = (Time.time - br.startTime)/800;
        float totalDistance = Vector3.Distance(cameraa.transform.position, ball.transform.position);
        float distanceCover = timecover/ totalDistance;
        cameraa.transform.position = Vector3.Lerp(cameraa.transform.position, ball.transform.position, distanceCover);
        if (cameraa.transform.position == ball.transform.position)
        {
            Destroy(this);
        }
    }

    void movementWithoutLerp()
    {
        cameraa.transform.position = ball.transform.position;
        Debug.Log("movement slowly method call");
    }
}
