using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;
    public bool startPlaying;
    public Scroller scroller;
    public static GameManager instance;
    public int currentScore;
    public int scorePerNote = 100;
    public Text scoreText;
    public Text multiText;
    public Text HealthText;
    public int currMult;
    public Sprite TitleScreen;
    public int health;
    public bool endBool;
    public bool youWin;
    // Start is called before the first frame update
    void Start()
    {
        EndScript.instance.StartGame();
        WinScript.instance.StartGame();
        instance = this;
        currMult = 1;
        currentScore = 0;
        health = 3;
        endBool = false;
        startPlaying = false;
        scroller.hasStarted = false;
        youWin = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (!startPlaying)
        {
            if (Input.anyKeyDown)
            {
                startPlaying = true;
                scroller.hasStarted = true;
                TitleScript.instance.StartGame();

                theMusic.Play();
                scoreText.text = "Score: 0";
                multiText.text = "Multiplier: x1";
                HealthText.text = "Health: 3/3";

            }

        }
        if (endBool)
        {
            if (Input.anyKeyDown)
            {
                SceneManager.LoadScene("MainScene");
            }

        }
        if (youWin)
        {
            YouWin();
        }
    }
    public void NoteHit()
    {
        Debug.Log("Hit Note");
        currentScore = currentScore + (scorePerNote * currMult);
        currMult += 1;
        scoreText.text = "Score: " + currentScore;
        multiText.text = "Multiplier: x" + currMult;
    }
    public void NoteMissed()
    {
        Debug.Log("Missed Note");
        currMult = 1;
        scoreText.text = "Score: " + currentScore;
        multiText.text = "Multiplier: x" + currMult;
    }

    public void AsteroidHit()
    {
        Debug.Log("Asteroid Hit");
        health -= 1;
        if (health == 0)
            DeathScreen();
        currMult = 1;
        scoreText.text = "Score: " + currentScore;
        multiText.text = "Multiplier: x" + currMult;
        HealthText.text = "Health: " + health + "/3";
    }

    private void DeathScreen()
    {
        theMusic.Stop();
        EndScript.instance.EndGame();
    }
    private void YouWin()
    {
        WinScript.instance.EndGame();
    }
}
