using UnityEngine;
using UnityEngine.SceneManagement;

public class SubMenu : MonoBehaviour
{
    //come back sub menu to main menu
    public void SubmenuBackToMainmenu()
    {
        Debug.Log("Room Application Open");
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
    //every scene to back to sub menu(BACK BUTTON).
    public void BackToSubmenu()
    {
    
        Debug.Log("Sub Menu Open");
        SceneManager.LoadScene("SubMenu", LoadSceneMode.Single);

    }

    //SCENES
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
    
    //Multifloor With fan then simple Multifloor. 
    public void OneStepBack()
    {
        SceneManager.LoadScene("MultiLevelFloor", LoadSceneMode.Single);
        Debug.Log("Sub Menu Open");  
    }

    public void ExitOption(GameObject gameExitObj)
    {
        gameExitObj.SetActive(false);
        Debug.Log("Option closed");
    }

    public void Gameplay()
    {
        SceneManager.LoadScene("GamePlayer", LoadSceneMode.Single);
        Debug.Log("Game Player Open");
    }
}
