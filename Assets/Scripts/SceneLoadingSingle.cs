using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadingSingle : MonoBehaviour
{
    void OnMouseDown()
    {
        LoadNextScene();
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene("MultiFloorWithFan", LoadSceneMode.Single);
    }
}
