using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow1 : MonoBehaviour
{
    public Transform start;
    //public Transform end;
    public GameObject ball;
    public float speed = 1.0F;
    private float startTime;
    private float journeyLength;
    public Vector3 movTopos;

    void Start()
    {
        // Keep a note of the time the movement started.
        startTime = Time.time;
        Debug.Log(startTime);
        // Calculate the journey length.

 /*       journeyLength = Vector3.Distance(start.position, end.position);
        Debug.Log(journeyLength);*/

        // object call and assign transform
        
        //end = gameObject.GetComponent<BallRotates>().transform;
        //Debug.Log(end);
    }

    private void OnMouseDown()
    {
        ball = gameObject.GetComponent<BallRotates>().gameObject;
    }

    void Update()
    {
        CopysMethod();
        // movementWithoutLerp();
    }

    void CopysMethod()
    {
        // Distance moved equals elapsed time times speed..
        float distCovered = (Time.time - startTime) * speed;
        Debug.Log(distCovered);

        // Fraction of journey completed equals current distance divided by total distance.
        float fractionOfJourney = distCovered / journeyLength;
        Debug.Log(fractionOfJourney);

        // Set our position as a fraction of the distance between the markers.

        //transform.position = Vector3.Lerp(start.position, end.position, fractionOfJourney);
        Debug.Log(transform.position);
    }
}
