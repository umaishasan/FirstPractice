using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadingAdditive : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LoadNextScene();
            Destroy(this);
        }
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene("ScenesLoadForAdditive",LoadSceneMode.Additive);
    }
}
