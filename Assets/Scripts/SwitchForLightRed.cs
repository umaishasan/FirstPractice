using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchForLightRed : MonoBehaviour
{
    public Light light;

    void OnMouseDown()
    {
        light.color = Color.red;
    }

    void OnMouseOver()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        Debug.Log("Red light hovered");
    }

    void OnMouseExit()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.red;
        Debug.Log("Red light un-hovered");
    }
}
