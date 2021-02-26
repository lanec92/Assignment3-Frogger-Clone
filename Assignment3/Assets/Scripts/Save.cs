using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Save : MonoBehaviour
{
    public List<int> livingCarPositions = new List<int>();
    public List<int> livingCarTypes = new List<int>();

    public int score = 0;
    public int lives = 0;
}

