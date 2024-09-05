using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{

    public Sprite[] background;
    int imageNumber;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = background[Random.Range(0, background.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
