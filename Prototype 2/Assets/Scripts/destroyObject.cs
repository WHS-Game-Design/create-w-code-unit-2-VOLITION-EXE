using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class destroyObject : MonoBehaviour
{
    // Start is called before the first frame update
    //private float topDespawn = 41;
    //private float lowDespawn = -4;
    public float projSpeed;
    //public GameObject Player_dude_kiryu_person;



    // Update is called once per frame

    healthSystem health = new healthSystem(5);

    public void OnTriggerEnter(Collider other){
    
    }
    

    void Update()
    {
        transform.Translate(projSpeed * Time.deltaTime * Vector3.forward);

        //if(lowDespawn > transform.position.z){
        //health.damage(1);
        //Destroy(gameObject);
        //}
    }

    

}