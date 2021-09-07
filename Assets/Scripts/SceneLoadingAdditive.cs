using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadingAdditive : MonoBehaviour
{
    void OnMouseDown()
    {
        LoadNextScene();
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene("ScenesLoadForAdditive",LoadSceneMode.Additive);
    }

}
