using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class destroyObject : MonoBehaviour
{
    // Start is called before the first frame update
    //private float topDespawn = 41;
    private float lowDespawn = -4;
    public float projSpeed;
    private PlayerController MyPlayer;
    public GameObject Player_dude_kiryu_person;



    // Update is called once per frame
    public float heath;

    public void OnTriggerEnter(Collider other){

    Destroy(other);
    Destroy(gameObject);
    
    }
    
    void Start(){
        Player_dude_kiryu_person.GetComponent<PlayerController>().healthAmount = heath;
    }

    void Update()
    {
        if(MyPlayer.Pause == false){
        transform.Translate(projSpeed * Time.deltaTime * Vector3.forward);
        }

        if(lowDespawn > transform.position.z){
        heath--; 
        Destroy(gameObject);
        }
    }

    

}