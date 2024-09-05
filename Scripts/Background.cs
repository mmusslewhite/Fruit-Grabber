using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{

    public Sprite[] background;

    // Start is called before the first frame update
    void Start()
    {

        int imageNumber = Random.Range(0, 7);
        GetComponent<SpriteRenderer>().sprite = background[imageNumber];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
