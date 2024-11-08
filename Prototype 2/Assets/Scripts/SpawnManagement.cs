using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnManagement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Prefabs;
    public GameObject[] powerUps;
    public float spawnRate;
    public float powerSpawnRate;
    void Start()
    {
        
        InvokeRepeating("SpawnRandom", spawnRate + 1 ,spawnRate);
        InvokeRepeating("SpawnPowerUps", powerSpawnRate + 1 ,powerSpawnRate);

    }

    void Update()
    {
        //SpawnRandom();

    }
    void SpawnRandom()
    {
        int index = Random.Range(0, Prefabs.Length);
        Instantiate(Prefabs[index], new Vector3(Random.Range(-24, 24),0, 40), Prefabs[index].transform.rotation);
    }

    void SpawnPowerUps()
    {
        int inde = Random.Range(0, Prefabs.Length);
        Instantiate(powerUps[inde], new Vector3(Random.Range(-24, 24),0, 40), powerUps[inde].transform.rotation);
    }
}

