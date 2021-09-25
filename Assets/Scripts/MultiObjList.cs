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
    //Color[] myColors = { Color.red, Color.green, Color.blue, Color.white };
    public GameObject[] myGameObj = { GameObject.Find("RedPlayer"), GameObject.Find("GreenPlayer"), GameObject.Find("BluePlayer"), GameObject.Find("WhitePlayer") };

    private void Update()
    {
        //multicast delegate
        myDelegated += showOutputinConsole;
       // myDelegated += ObjextPositionChange;

        //type space to generate cube
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int myGameObjIndex = Random.Range(0, myGameObj.Length);
            //glist.Add(Instantiate(myGameObj[myGameObjIndex]));
            glist.Add(Instantiate(myGameObj[myGameObjIndex]));
            glist[i].transform.localPosition = new Vector3(transform.position.x + i * 2, transform.position.y, transform.position.z);

            //ObjextPositionChange();
            dlist.Add("cube" + i, glist);
            myDelegated();
            i++;
            Debug.Log(i + " " + dlist.GetType() + " " + dlist.ToString());
        }
    }


    void showOutputinConsole()
    {
        print("show output method call using delegate");
    }

    void ObjextPositionChange()
    {
        for (int i = 0; i < glist.Count; i++)
        {
            if (glist[i].GetComponent<Renderer>().material.color == Color.red)
            {
                glist[i].transform.localPosition = new Vector3(transform.position.x + i * 2, transform.position.y, transform.position.z);
            }
            if (glist[i].GetComponent<Renderer>().material.color == Color.green)
            {
                //glist.Add(GameObject.CreatePrimitive(PrimitiveType.Cube));
                glist[i].transform.localPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z + i * 2);
            }
            if (glist[i].GetComponent<Renderer>().material.color == Color.blue)
            {
                //glist.Add(GameObject.CreatePrimitive(PrimitiveType.Cube));
                glist[i].transform.localPosition = new Vector3(transform.position.x + i * 2, transform.position.y, -transform.position.z + i * 2);
            }
            if (glist[i].GetComponent<Renderer>().material.color == Color.white)
            {
                Destroy(this);
            }
        }
    }
    //2nd method
    /*GameObject.Find("Cube").GetComponent<Renderer>().material.color = Color.red;
    GameObject.Find("Cube").transform.position = new Vector3(2f,0f,0f);*/
}
