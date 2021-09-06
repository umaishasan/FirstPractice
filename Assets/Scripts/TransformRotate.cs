using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformRotate : MonoBehaviour
{

    private void Awake()
    {
        Debug.Log("Awake method call");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start method call");
        gameObject.active = false;
    }

    // Update is called once per frame
    void Update()
    {
        /*transform.Rotate(Vector3.forward * 2);*/
        /*transform.Rotate(Vector3.up * 2);*/
       /* transform.Rotate(Vector3.down * 2);*/
        transform.Rotate(Vector3.back * 2);
        Debug.Log("Update method call");
    }
}
