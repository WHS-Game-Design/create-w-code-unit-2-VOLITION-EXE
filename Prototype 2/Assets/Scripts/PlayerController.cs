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
    public int healthMax = 4;
    public float speed;
    public Vector3 pos = new Vector3(0, 0, -10);
    public GameObject pizzaProj;
    public bool Pause = false;
    public bool _Pause
    {get{return Pause;}} 
    private PorjectleMove projectile;
    //healthSystem health = new healthSystem(5);
    public static float health;
    
    
    //public Coroutine shield;

    void Start(){
        //InvokeRepeating("healthCheck", 1 ,1);
        projectile = pizzaProj.GetComponent<PorjectleMove>();
        health = healthMax + 1;

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
        if (Input.GetKeyDown(KeyCode.Y)){
            health--;
            
        }
        Debug.Log(health);
        if (Input.GetKeyDown(KeyCode.U)){
            health++;
            Debug.Log(health);
        }
        if (projectile.healthhit == true){
            health++;
            Debug.Log(health);
            projectile.healthhit = false;
        
        }
        if(health <= 1){
        health = 0;
        }
        if(health >= healthMax){
        health = healthMax;
        }
    
    }
    


    public void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.CompareTag("Enemy")){
            if(projectile.invincible == false && health > 0){
                health--;
            }
        Debug.Log("Enemy entered trigger");
        if (projectile.invincible == true){
            Debug.Log("shield entered trigger");
        }
        
    }
    }
    public void OnTriggerExit(Collider other){
        Destroy(other.gameObject);
    }
}
