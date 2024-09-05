using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCount : MonoBehaviour
{
    
    [SerializeField] public TextMeshProUGUI score_text;
    GameController gameController;
    
    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore() {
        score_text.text = gameController.score.ToString();
    }

    
}
