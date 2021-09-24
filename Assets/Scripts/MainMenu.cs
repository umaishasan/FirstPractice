using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject panelAboutUs;
    public GameObject panelHighScore;
    public GameObject panelSubmenu;
    public bool aboutusPanel;
    public bool scorePanel;
    public bool submenuPanel;

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Application Closed");
    }

    public void BackToMainmenu()
    {
        Debug.Log("Sub Menu Open");
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    public void StatMenu()
    {
        SceneManager.LoadScene("SubMenu", LoadSceneMode.Single);
        Debug.Log("Sub Menu Open");
        /*if (submenuPanel)
        {
            panelSubmenu.SetActive(true);
            panelAboutUs.SetActive(false);
            panelHighScore.SetActive(false);
        }
        else
        {
            panelSubmenu.SetActive(false);
            panelAboutUs.SetActive(false);
            panelHighScore.SetActive(false);
        }*/
    }
    public void AboutUS()
    {
        Debug.Log("AboutUs Open");
        if (aboutusPanel)
        {
            panelAboutUs.SetActive(true);
            panelHighScore.SetActive(false);
            panelSubmenu.SetActive(false);
        }
        else
        {
            panelSubmenu.SetActive(false);
            panelAboutUs.SetActive(false);
            panelHighScore.SetActive(false);
        }
    }
    public void HighScore()
    {
        Debug.Log("HighScore Open");
        if (scorePanel)
        {
            panelHighScore.SetActive(true);
            panelAboutUs.SetActive(false);
            panelSubmenu.SetActive(false);
        }
        else
        {
            panelSubmenu.SetActive(false);
            panelAboutUs.SetActive(false);
            panelHighScore.SetActive(false);
        }
    }
}
