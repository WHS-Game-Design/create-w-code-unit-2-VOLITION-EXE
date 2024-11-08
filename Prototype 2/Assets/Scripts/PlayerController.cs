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
    public float healthAmount;

    void Start(){

        healthAmount = 5;
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
    
    }

    public void OnTriggerEnter(Collider other)
    {

    if (other.gameObject.tag != "health_Regain"){
    Destroy(other);
    healthAmount =+ 1;
    }

    }

    
}
