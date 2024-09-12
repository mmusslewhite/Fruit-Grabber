using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestroyFruit : MonoBehaviour
{

    public UnityEvent collectFruit;
    public GameObject collected;
    public UnityEvent collectAlternateFruit;
    

    void Start() {
        collectFruit.AddListener(GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().IncrementScore);
        collectFruit.AddListener(GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreCount>().UpdateScore);

        collectAlternateFruit.AddListener(GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().AlternateScore);
        collectAlternateFruit.AddListener(GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreCount>().UpdateScore);
    }
    void OnMouseDown()
    {
        if (!PauseMenu.isPaused)
        {
            if (gameObject.tag == "PrimaryFruit")
            {
                collectFruit.Invoke();
                Destroy(gameObject);
                Vector2 mousePos = Input.mousePosition;
                Vector2 objectPos = Camera.main.ScreenToWorldPoint(mousePos);
                Instantiate(collected, objectPos, Quaternion.identity);
                Debug.Log(gameObject.name + "collected!");
            }
            else
            {
                collectAlternateFruit.Invoke();
                Destroy(gameObject);
                Vector2 mousePos = Input.mousePosition;
                Vector2 objectPos = Camera.main.ScreenToWorldPoint(mousePos);
                Instantiate(collected, objectPos, Quaternion.identity);
                Debug.Log(gameObject.name + "collected!");
            }
        }
    }
    
}
