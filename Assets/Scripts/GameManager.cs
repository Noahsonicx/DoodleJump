using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject platformPrefab;

    public int numberOfPlatforms = 100;

    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(.5f, 4f);
            spawnPosition.x = Random.Range(-10f, 10f);
            // Instantiates the spawnPosition and rotation of the platform prefab
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }


    
}
