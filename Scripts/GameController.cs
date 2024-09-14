using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using System;

public class GameController : MonoBehaviour
{
    public int Score { get; set; }
    public bool GoldMode = false;
    public GameObject goldFrame;
    private float timer = 0;
    public float goldTime = 20;
    public TextMeshProUGUI score;

    void Update()
    {
        if (GoldMode == true)
        {
        timer += Time.deltaTime;

            if (timer > goldTime) {
            GoldMode = false;
            goldFrame.SetActive(false);
            timer = 0;
            }

        }
    }

    public void IncrementScore() 
    {if (!GoldMode)
        {
            Score++;
        } else
        {
            Score += 2;
        }
    }

    public void AlternateScore()
    {if (!GoldMode)
        {
            Score += 2;
        }
        else
        {
            Score += 4;
        }
    }

    public void GoGoldMode()
    { 
        
        GoldMode = true;
        goldFrame.SetActive(true); 
        
    }

    public void SaveScore()
    {
        PlayerPrefs.SetInt("Score", Score);
    }
    
    public void LoadScore()
    {
        score.text = (PlayerPrefs.GetInt("Score").ToString());
    }

    
}
