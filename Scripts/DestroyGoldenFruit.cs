using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestroyGoldenFruit : MonoBehaviour
{

    public UnityEvent collectGoldenFruit;
    public GameObject collected;

    void Start()
    {
        collectGoldenFruit.AddListener(GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().GoGoldMode);
        collectGoldenFruit.AddListener(GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreCount>().UpdateScore);

    }

    private void OnMouseDown()
    {
        if (!PauseMenu.isPaused)
        {
            collectGoldenFruit.Invoke();
            Destroy(gameObject);
            Vector2 mousePos = Input.mousePosition;
            Vector2 objectPos = Camera.main.ScreenToWorldPoint(mousePos);
            Instantiate(collected, objectPos, Quaternion.identity);
            Debug.Log(gameObject.name + "collected!");
        }
    }

}
