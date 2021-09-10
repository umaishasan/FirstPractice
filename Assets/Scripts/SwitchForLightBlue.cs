using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchForLightBlue : MonoBehaviour
{
    public Light light;

    void OnMouseDown()
    {
        light.color = Color.blue;
    }

    void OnMouseOver()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        Debug.Log("blue light hovered");
    }

    void OnMouseExit()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.blue;
        Debug.Log("blue light un-hovered");
    }
}
