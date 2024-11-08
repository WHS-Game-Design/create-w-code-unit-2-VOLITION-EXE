using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUps : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(-4 > transform.position.z){
        Destroy(gameObject);
        }

    }
    public void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag == "Player_dude_kiryu_person"){
        Destroy(gameObject);
        //}
    }
}
