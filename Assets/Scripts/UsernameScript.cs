using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UsernameScript : MonoBehaviour
{

    public Text nameHeadingTxt;
    public GameObject objExit;
    public static string nameTxt = "";


    public void ObjectExit()
    {
        nameHeadingTxt.text = nameTxt;
        objExit.SetActive(false);

    }    
    public void ObjectExitFormX()
    {
        objExit.SetActive(false);
    }

    public void CopyPasteInputfield(string inputName)
    {
        nameTxt = inputName;
        Debug.Log(nameTxt);
    }
}
