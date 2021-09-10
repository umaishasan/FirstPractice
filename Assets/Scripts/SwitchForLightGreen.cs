using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchForLightGreen : MonoBehaviour
{
    public Light light;

    void OnMouseDown()
    {
        light.color = Color.green;
    }

    void OnMouseOver()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        Debug.Log("green light hovered");
    }

    void OnMouseExit()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.green;
        Debug.Log("green light un-hovered");
    }
}
