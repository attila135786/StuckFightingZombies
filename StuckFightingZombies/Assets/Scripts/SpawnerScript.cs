using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{


    public GameObject[] gameObjectsToSpawn;
    public float spawnInterval = 1000;

    private float timeSinceLastUpdate = 0;
    private Random random = new Random();

    void Start()
    {

    }

    void Update()
    {
        if (timeSinceLastUpdate >= spawnInterval)
        {
            spawnZombie();
            timeSinceLastUpdate = 0;
        }

        timeSinceLastUpdate += Time.deltaTime;
    }

    private void spawnZombie()
    {
        int randomInteger = Random.Range(0, gameObjectsToSpawn.Length);
        Debug.Log(randomInteger);
        GameObject zombie = Instantiate(gameObjectsToSpawn[randomInteger], transform.position, transform.rotation);
    }
}
