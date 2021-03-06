﻿using UnityEngine;
using UnityEngine.SceneManagement;
public class Frog : MonoBehaviour
{
    public Rigidbody2D rb;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            if (transform.position.x < 8f)
            {
                rb.MovePosition(rb.position + Vector2.right);

            }
            else
            {
                Vector2 newPos = new Vector2(7f, -4f);
                transform.position = newPos;
            }

        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            if (transform.position.x > -8f)
            {
                rb.MovePosition(rb.position + Vector2.left);

            }
            else
            {
                Vector2 newPos = new Vector2(-7f, -4f);
                transform.position = newPos;
            }
        }

        else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
            rb.MovePosition(rb.position + Vector2.up);

        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            if (transform.position.y > -4f)
            {
                rb.MovePosition(rb.position + Vector2.down);

            }
            else
            {
                Vector2 newPos = new Vector2(transform.position.x, -4f);
                transform.position = newPos;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Car")
        {
            Debug.Log("WE LOST!");
            //Score.CurrentScore = 0;
            PickLives.playerLives -= 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
        Debug.Log("Game Saved!");
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        Debug.Log("Loaded Game w/" + data.currScore + " " + data.currLives);
        Score.CurrentScore = data.currScore;
        PickLives.playerLives = data.currLives;

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;

    }

    public void SaveAsJSON()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        string json = JsonUtility.ToJson(data);
        Debug.Log("Saving as JSON: " + json);
    }
}
