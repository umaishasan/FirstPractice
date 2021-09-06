using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchForfan : MonoBehaviour
{
    public FanRotate fanrotate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {   
        fanrotate.enabled = true;
    }

    private void OnMouseUpAsButton()
    {
        fanrotate.enabled = false;
    }

}
