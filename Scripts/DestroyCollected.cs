using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCollected : MonoBehaviour
{
    

    private void Update()
    {
        Destroy(gameObject, .5f);
    }
}
