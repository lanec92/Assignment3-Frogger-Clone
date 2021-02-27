using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public static int CurrentScore = 0;

    public Text scoreText;

    void Awake ()
    {
        scoreText.text = CurrentScore.ToString();
    }
    void Update()
    {
        scoreText.text = CurrentScore.ToString();
    }
}
