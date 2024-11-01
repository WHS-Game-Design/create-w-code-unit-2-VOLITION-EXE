using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnManagement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Prefabs;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnRandom();
    }
    void SpawnRandom()
    {
        int index = Random.Range(0, Prefabs.Length);
        Instantiate(Prefabs[index], new Vector3(Random.Range(-24, 24),0, 40), Prefabs[index].transform.rotation);
    }
}
