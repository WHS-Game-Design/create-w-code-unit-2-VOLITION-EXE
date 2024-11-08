using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hearts : MonoBehaviour
{
    public GameObject healthimage;
    public float healthThreshold;
    public PlayerController player;

    void Start()
    {

    }
    void Update()
    {
        if (player.healthAmount >= healthThreshold)
        {
            healthimage.SetActive(true);
        } else {
            healthimage.SetActive(false);
        }
        
        
    }
    
}
