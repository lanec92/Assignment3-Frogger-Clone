﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumLives : MonoBehaviour
{
   
    public Text livesText;

    void Awake()
    {
        if (PickLives.playerLives == 0)
        {
            PickLives.playerLives += 1;
            livesText.text = PickLives.playerLives.ToString();
        }
        else
        {
            livesText.text = PickLives.playerLives.ToString();

        }
    }

    void Update()
    {
        if (PickLives.playerLives == 0)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            livesText.text = PickLives.playerLives.ToString();

        }
    }
}
