using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchForLightGreen : MonoBehaviour
{
    public Light light;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnMouseDown()
    {
        switchLight();
    }

    void switchLight()
    {
        light.color = Color.green;
    }
}
