using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public float score;
    public float highScore;
    public Text scoreTxt;
    public Text highScoreTxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        highScore = PlayerPrefs.GetFloat("Highscore");
        scoreTxt.text = " " + score;
        highScoreTxt.text = "HighScore : " + highScore;

        if(score > highScore){
            PlayerPrefs.SetFloat("Highscore", score);
        }
    }

    public void AddScore()
    {
        score++;
    }
}
