using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchForfan : MonoBehaviour
{
    public FanRotate fanrotate;

    void OnMouseDown()
    {
        if(fanrotate.enabled == false)
        {
            fanrotate.enabled = true;
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            fanrotate.enabled = false;
        }
    }

    void OnMouseExit()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.white;   
    }
}
