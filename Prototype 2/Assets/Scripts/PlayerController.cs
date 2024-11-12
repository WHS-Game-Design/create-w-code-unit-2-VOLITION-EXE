using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;
    public Vector3 pos = new Vector3(0, 0, -10);
    public GameObject pizzaProj;
    public bool Pause = false;
    public GameObject[] powerUps;
    public bool _Pause
    {get{return Pause;}} 
    healthSystem health = new healthSystem(5);

    void Start(){
        //InvokeRepeating("healthCheck", 1 ,1);
    }

    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.position = pos.x * Vector3.right;
        if (Pause == false){
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        }
        pos.x =  Mathf.Clamp(transform.position.x, -24f, 24f);
        if (Input.GetKeyDown(KeyCode.Space)){
            Instantiate(pizzaProj, transform.position, pizzaProj.transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.P)){
            if (Pause) Pause = false;
            else Pause = true;
        }
        if (Input.GetKeyDown(KeyCode.Y)) health.damage(1);
        if (Input.GetKeyDown(KeyCode.U)) health.regain(1);
        Debug.Log(health.getHealth());

    
    }
    public void healthCheck(){
       
    }

    public void OnTriggerEnter(Collider other)
    {

    if (other.gameObject.tag != "health_Regain"){
        health.damage(1);
        Destroy(other);
    }

    }

    
}
