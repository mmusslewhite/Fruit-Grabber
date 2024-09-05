using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameController : MonoBehaviour
{
    public int score { get; private set; }
    public bool GoldMode = false;
    public GameObject goldFrame;
    private float timer = 0;
    public float goldTime = 20;

    public void IncrementScore() 
    {if (!GoldMode)
        {
            score++;
        } else
        {
            score += 2;
        }
    }

    public void AlternateScore()
    {if (!GoldMode)
        {
            score += 2;
        }
        else
        {
            score += 4;
        }
    }

    public void GoGoldMode()
    { 
        timer += Time.deltaTime;
        
        if (timer < goldTime)
        {
            GoldMode = true;
            goldFrame.SetActive(true);
        } else
        {
            GoldMode = false;
            goldFrame.SetActive(false);
            timer = 0;
        }
        
    }
    
}
