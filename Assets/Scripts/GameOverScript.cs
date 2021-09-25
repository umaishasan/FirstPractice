using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    //float speddd;
    public Animator anim;

    void Start()
    {
        StartCoroutine(AfterGameOver());  
    }

    IEnumerator AfterGameOver()
    {
        yield return new WaitForSeconds(1.4f);
        anim.Play("gameoverBack");
        SceneManager.LoadScene("SubMenu", LoadSceneMode.Single);
    }
}
