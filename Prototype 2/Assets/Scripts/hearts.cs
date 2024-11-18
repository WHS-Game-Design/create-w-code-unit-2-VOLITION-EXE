using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hearts : MonoBehaviour
{
    //public GameObject healthimage;
    public float healthThreshold;
    //private healthSystem Hp;
    public Image MyImage;
    

    void Start()
    {
        //Hp = FindObjectOfType<healthSystem>();
        //healthSystem health = new healthSystem(5);
    }
    void Update()
    {
        if (PlayerController.health >= healthThreshold)
        {
            MyImage.gameObject.SetActive(true);
        } else {
            MyImage.gameObject.SetActive(false);
        }
        
        
    }
    
}
