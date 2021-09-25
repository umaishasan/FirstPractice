using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreNameScript : MonoBehaviour
{
    public Text nameText;
    public Text scoreText;

    void Update()
    {
        NameTxt();
        ScoreTxt();
    }

    void NameTxt()
    {
        nameText.text = UsernameScript.nameTxt;
    }
    void ScoreTxt()
    {
        scoreText.text = ActionPlayer.Score.ToString();
    }
}
