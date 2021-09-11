using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchesForLight : MonoBehaviour
{
    public GameObject Light;
    public GameObject targetObj;

    void OnMouseDown()
    {
        if (Light.GetComponent<Light>().enabled == true)
        {
            Light.GetComponent<Light>().enabled = false;
        }
        else
        {
            Light.GetComponent<Light>().enabled = true;
        }
    }

    void OnMouseOver()
    {
        targetObj.GetComponent<Renderer>().material.color = Color.cyan;
    }

    void OnMouseExit()
    {
        targetObj.GetComponent<Renderer>().material.color = Color.white;
    }
}
