using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Fruits {
    public GameObject Prefab;
    [Range (0f, 100f)]public float Chance = 100f;
    [HideInInspector]public double _weight;
}
public class Spawner : MonoBehaviour
{

    private float timer = 0;
    private float heightOffset = 3.5f;
    private float widthOffset = 7.5f;
    public Fruits[] fruits;
    public float spawnRate = 5;
    private double accumulatedWeights;
    private System.Random rand = new System.Random();
    

    void Awake()
    {
        CalculateWeights();
    }
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        if (timer < spawnRate) {
            timer += Time.deltaTime;
        } else {
        spawnFruits();
        timer = 0;
        }
    }

    private int GetRandomFruitIndex() {
        double r = rand.NextDouble() * accumulatedWeights;
        for (int i = 0; i < fruits.Length; i++)
            if(fruits [ i ]._weight >=r)
            return i;
        
        return 0;
    }

    private void CalculateWeights () {
        accumulatedWeights = 0f;
        foreach (Fruits fruits in fruits) {
            accumulatedWeights += fruits.Chance;
            fruits._weight = accumulatedWeights;
        }
    }





    public void spawnFruits() {
        Fruits randomFruits = fruits [GetRandomFruitIndex()];
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        float leftPoint = transform.position.x - widthOffset;
        float rightPoint = transform.position.x + widthOffset;

        GameObject clone = Instantiate(randomFruits.Prefab, new Vector3(Random.Range(leftPoint, rightPoint), Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        Destroy(clone, 20f);
    }

}
