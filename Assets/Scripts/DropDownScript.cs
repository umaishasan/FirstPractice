using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DropDownScript : MonoBehaviour
{
    public Dropdown dropdown;
    public GameObject proceedBtnLight;
    public GameObject proceedBtnMoveobj;
    public GameObject proceedBtnGen;

    public void DropdownList()
    {
        if(dropdown.value == 1)
        {
            proceedBtnLight.SetActive(true);
        }
        else if(dropdown.value == 2)
        {
            proceedBtnMoveobj.SetActive(true);
        }
        else if (dropdown.value == 3)
        {
            proceedBtnGen.SetActive(true);
        }
    }

    //SCENES
    public void List()
    {
        Debug.Log("List Application Open");
        SceneManager.LoadScene("MultiObjInList", LoadSceneMode.Single);
    }
    public void Light()
    {
        Debug.Log("Light Application Open");
        SceneManager.LoadScene("SwitchLight", LoadSceneMode.Single);
    }
    public void ObjectMove()
    {
        Debug.Log("ObjectMove Application Open");
        SceneManager.LoadScene("Translate&Rotate", LoadSceneMode.Single);
    }
}
