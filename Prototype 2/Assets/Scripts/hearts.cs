using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hearts : MonoBehaviour
{
    public GameObject healthimage;
    public float healthThreshold = 1;
    private healthSystem Hp;

    void Start()
    {
        //Hp = FindObjectOfType<healthSystem>();
        //healthSystem health = new healthSystem(5);
    }
    void Update()
    {
        if (Hp.healthAmount >= healthThreshold)
        {
            healthimage.SetActive(true);
            Debug.Log("healthy");
        } else {
            healthimage.SetActive(false);
            Debug.Log("not healthy");
        }
        
        
    }
    
}
