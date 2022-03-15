using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public GameObject GameOverUI;
    public bool gameOver = false;
    public bool play = true;
    public GameObject startButton;
    public GameObject Slime;
    public GameObject score;
    public GameObject Log;
    public GameObject Log2;
    public GameObject pipeSpawner;
    

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }

        Application.targetFrameRate = 60;
        
        if(Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();
        }
    }

    public void Play(){
        startButton.SetActive(false);
        score.SetActive(true);
        gameOver = false;

        pipeSpawner.SetActive(true);
        Log.SetActive(true);
        Log2.SetActive(true);
        Time.timeScale = 1f;
        Slime.SetActive(true);
    }

    public void Pause(){
        if(gameOver == true)
        {
            Time.timeScale = 0f;
            Slime.SetActive(true);
        }
        else
        {
            Awake();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver == true && Input.GetMouseButtonDown(1))
        {
            SceneManager.LoadScene(0);
        }
        if(gameOver == true && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void GameOver(){
        gameOver = true;
        GameOverUI.SetActive(true);
        // startButton.SetActive(true);
        // Pause();
    }

    public void SlimeDied(){
        // GameOverUI.SetActive(true);
        // gameOver = true;
        GameOver();
    }
}
