using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    int number = 5;
    bool checxCondition;

    // Start is called before the first frame update
    void Start()
    {
        //WhileLoop();
        DoWhileLoop();
    }

    void WhileLoop()
    {
        while (number > 0)
        {
            Debug.Log("number: " + number);
            number--;
        }
    }

    void DoWhileLoop()
    {
        do
        {
            Debug.Log("Hello");
        }
        while (checxCondition == true);
    }

}
