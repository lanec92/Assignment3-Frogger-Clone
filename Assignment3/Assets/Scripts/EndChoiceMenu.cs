using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndChoiceMenu : MonoBehaviour
{
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
