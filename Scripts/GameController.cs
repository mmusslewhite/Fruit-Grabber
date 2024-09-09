using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameController : MonoBehaviour
{
    public int Score { get; private set; }
    public bool GoldMode = false;
    public GameObject goldFrame;
    private float timer = 0;
    public float goldTime = 20;

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
    
}
