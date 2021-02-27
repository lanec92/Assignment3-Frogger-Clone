using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalLives : MonoBehaviour
{

    public Text finLivesText;

    void Awake()
    {
        if (PickLives.recordLives == 0)
        {
            PickLives.recordLives += 1;
            finLivesText.text = PickLives.recordLives.ToString();
        }
        else
        {
            finLivesText.text = PickLives.recordLives.ToString();
        }
    }
}
