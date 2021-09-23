using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownScript : MonoBehaviour
{
    public Dropdown dropdown;
    public GameObject proceedBtn;

    public void DropdownList()
    {
        if(dropdown.value == 0)
        {
            proceedBtn.SetActive(true);
            ProceedButton(0);
        }
        else if(dropdown.value == 1)
        {
            proceedBtn.SetActive(true);
            ProceedButton(1);
        }
        else if (dropdown.value == 2)
        {
            proceedBtn.SetActive(true);
            ProceedButton(2);
        }
    }

    void ProceedButton(int indexNum)
    {
        if(indexNum == 0)
        {

        }
        else if(indexNum == 1)
        {

        }
        else if (indexNum == 2)
        {

        }
    }
}
