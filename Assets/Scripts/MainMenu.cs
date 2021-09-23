using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject panelAboutUs;
    public GameObject panelHighScore;
    public bool aboutusPanel;
    public bool scorePanel;
    //public bool menusPanel;

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Application Closed");
    }

    //next scene open then exit
    public void ExitObjectss(GameObject gameObjj)
    {
        gameObjj.SetActive(false);
        Debug.Log("object Closed");
    }

    public void Room()
    {
        Debug.Log("Room Application Open");
        SceneManager.LoadScene("Room",LoadSceneMode.Single);

    }
    public void Camera()
    {
        Debug.Log("Camera Application Open");
        SceneManager.LoadScene("MultiCamAtaTime", LoadSceneMode.Single);

    }
    public void Floor()
    {
        Debug.Log("Floor Application Open");
        SceneManager.LoadScene("MultiLevelFloor", LoadSceneMode.Single);

    }
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

    //every scene to back to sub menu.
    public void backTomainMenu()
    {
        Debug.Log("Sub Menu Open");
        SceneManager.LoadScene("SubMenu", LoadSceneMode.Single);
    }

    //when switch to next scene to current scene then one step back scene. 
    public void oneStepBack()
    {
        SceneManager.LoadScene("MultiLevelFloor", LoadSceneMode.Single);
        Debug.Log("Sub Menu Open");  
    }

    public void StatMenu()
    {
        SceneManager.LoadScene("SubMenu", LoadSceneMode.Single);
        Debug.Log("Sub Menu Open");
    }

    public void AboutUS()
    {
        Debug.Log("AboutUs Open");
        if (aboutusPanel)
        {
            panelAboutUs.SetActive(true);
            panelHighScore.SetActive(false);
        }
        else
        {
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
        }
        else
        {
            panelHighScore.SetActive(false);
            panelAboutUs.SetActive(false);
        }
    }
}
