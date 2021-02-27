﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject PauseMenuUI;

    void Awake()
    {
        Resume();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void NewGame()
    {
        Score.CurrentScore = 0;
        PickLives.playerLives = 3;
        SceneManager.LoadScene(1);
        Resume();
    }

    public void QuitGame()
    {

        Application.Quit();
        Debug.Log("Quit Game");
    }

    public void MainMenu()
    {
        Score.CurrentScore = 0;
        SceneManager.LoadScene(0);
    }

}
