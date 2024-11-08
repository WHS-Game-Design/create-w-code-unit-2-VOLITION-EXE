using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PorjectleMove : MonoBehaviour
{
    private float topDespawn = 41;
    private float lowDespawn = -4;
    public float projSpeed;
    private PlayerController player;

    void Start() => player = FindObjectOfType<PlayerController>();

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
