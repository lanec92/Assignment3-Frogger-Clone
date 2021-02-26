using UnityEngine;
using UnityEngine.UI;


public class PickLives : MonoBehaviour
{
    public Dropdown LifeDropDown;

    public static int playerLives;

    public void NumLives()
    {
        switch (LifeDropDown.value)
        {

            case 1:
                playerLives = 1;
                break;

            case 2:
                playerLives = 2;
                break;

            case 3:
                playerLives = 3;
                break;

            default:
                playerLives = 1;
                break;

        }
    }
}
