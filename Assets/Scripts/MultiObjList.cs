using UnityEngine;
using System.Collections.Generic;

public class MultiObjList : MonoBehaviour
{
    //delegate define;
    delegate void myDelegate();
    myDelegate myDelegated;

    public List<GameObject> glist = new List<GameObject>();
    public Dictionary<string, List<GameObject>> dlist = new Dictionary<string, List<GameObject>>();
    private int i = 0;
    private float x;

    void Start()
    {

    }

    private void Update()
    {
        //multicast delegate
        myDelegated += showOutputinConsole;
        myDelegated += ObjextMeterialChange;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            glist.Add(GameObject.CreatePrimitive(PrimitiveType.Cube));
            dlist.Add("cube"+i, glist);
            myDelegated();
            i++;
            Debug.Log(i+" "+dlist.GetType()+" "+dlist.ToString());
        }
    }


    void showOutputinConsole()
    {
        print("show output method call using delegate");
    }

    void ObjextMeterialChange()
    {
        for(int i = 0; i < glist.Count; i++)
        {
            glist[i].GetComponent<Renderer>().material.color = Color.red;
            glist[i].transform.position = new Vector3(transform.position.x+i*2, transform.position.y, transform.position.z);
        }

        /*GameObject.Find("Cube").GetComponent<Renderer>().material.color = Color.red;
        GameObject.Find("Cube").transform.position = new Vector3(2f,0f,0f);*/
    }
}
