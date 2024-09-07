using System.Collections;
using System.Collections.Generic;
using UnityEditor.VisionOS;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Background : MonoBehaviour
{

    public Sprite[] background;
    GameController gameController;
    private int imageNumber;
    private int levelNumber = 1;


    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();

        int imageNumber = Random.Range(0, 7);
        GetComponent<SpriteRenderer>().sprite = background[imageNumber];
        
    }

    void Update()
    {
        
        if (levelNumber == 1 && gameController.Score >= 10)
        {
            changeBackground();
            levelNumber++;
        }

        if (levelNumber == 2 && gameController.Score >= 25)
        {
            changeBackground();
            levelNumber++;
        }

        if (levelNumber == 3 && gameController.Score >= 50)
        {
            changeBackground();
            levelNumber++;
        }

        if (levelNumber == 4 && gameController.Score >= 100)
        {
            changeBackground();
            levelNumber++;
        }

        if (levelNumber == 5 && gameController.Score >= 250)
        {
            changeBackground();
            levelNumber++;
        }

        if (levelNumber == 6 && gameController.Score >= 500)
        {
            changeBackground();
            levelNumber++;
        }

        if (levelNumber == 7 && gameController.Score >= 1000)
        {
            changeBackground();
            levelNumber++;
        }

        if (levelNumber == 8 && gameController.Score >= 2500)
        {
            changeBackground();
            levelNumber++;
        }

        if (levelNumber == 9 && gameController.Score >= 5000)
        {
            changeBackground();
            levelNumber++;
        }

        if (levelNumber == 10 && gameController.Score >= 10000)
        {
            changeBackground();
            levelNumber++;
        }

        if (levelNumber == 11 && gameController.Score >= 25000)
        {
            changeBackground();
            levelNumber++;
        }

        if (levelNumber == 12 && gameController.Score >= 50000)
        {
            changeBackground();
            levelNumber++;
        }

    }

    void changeBackground()
    {
        int imageNumber = Random.Range((int)levelNumber, 7);
        GetComponent<SpriteRenderer>().sprite = background[(int)imageNumber];
        Debug.Log("Background changed");
        
    }

}
