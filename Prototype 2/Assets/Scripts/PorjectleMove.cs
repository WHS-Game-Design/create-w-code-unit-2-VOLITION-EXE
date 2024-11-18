using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PorjectleMove : MonoBehaviour
{
    private float topDespawn = 41;
    private float lowDespawn = -20;
    public float projSpeed;
    private PlayerController player;
    //healthSystem health = new healthSystem(5);

    public float Shield;

    public bool invincible = false;
    public bool _invincible
    {get{return invincible;}} 
    private IEnumerator shieldCoroutine;
    public bool healthhit;
    public bool _healthhit
    {get{return healthhit;}}
    


    void Start(){
        player = FindObjectOfType<PlayerController>();

    }

    void OnTriggerEnter(Collider other){


        if(other.gameObject.CompareTag("health")){
            PlayerController.health++;

        }

        if(other.gameObject.CompareTag("shield")){
        StartCoroutine(hield(Shield));
        Debug.Log("shield entered trigger");
        }

        Destroy(other.gameObject);
        Destroy(gameObject);

    }

    IEnumerator hield(float shieldTime)
    {
        invincible = true;
        Debug.Log("shield on");
        yield return new WaitForSeconds(shieldTime);
        Debug.Log("shield off");
        invincible = false;
        //yield return new();
    }

    void Update()
    {
        if(player.Pause == false){
        transform.Translate(projSpeed * Time.deltaTime * Vector3.forward);
        }

        if(lowDespawn > transform.position.z || transform.position.z > topDespawn){
        Destroy(gameObject);
        }
        

    }


}