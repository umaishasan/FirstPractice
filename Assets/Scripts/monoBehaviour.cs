using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monoBehaviour : MonoBehaviour
{

    private void Awake()
    {
        Debug.Log("Awake method call");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start method call");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update method call");
    }

    void onEnable()
    {
        Debug.Log("onEnable method call");
    }

    void onDisable()
    {
        Debug.Log("onDisable method call");
    }
}
