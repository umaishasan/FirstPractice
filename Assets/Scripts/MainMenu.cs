using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Application Closed");
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

    public void backTomainMenu()
    {
        Debug.Log("Main Menu Open");
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    public void oneStepBack()
    {
        Debug.Log("Main Menu Open");
        SceneManager.LoadScene("MultiLevelFloor", LoadSceneMode.Single);
    }
}
