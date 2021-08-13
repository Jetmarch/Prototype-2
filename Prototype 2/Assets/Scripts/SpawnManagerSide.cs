using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerSide : MonoBehaviour
{
    public GameObject[] animalPrefab;
    public Vector3 animalLookRotation;
    public float spawnRate = 1.5f;
    public float spawnPosX = 20;
    public float spawnStartDelay = 4.0f;

    private float spawnRangeTopZ = 15;
    private float spawnRangeBottomZ = 0;
    
    


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", spawnStartDelay, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefab.Length);
        Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(spawnRangeBottomZ, spawnRangeTopZ));

        Instantiate(animalPrefab[animalIndex], spawnPos, Quaternion.Euler(animalLookRotation));
    }
}
