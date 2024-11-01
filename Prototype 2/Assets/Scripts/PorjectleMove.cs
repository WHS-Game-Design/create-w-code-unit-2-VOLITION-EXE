using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorjectleMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private float topDespawn = 41;
    private float lowDespawn = -4;
    public float projSpeed;
    void Update()
    {
        transform.Translate(Vector3.forward * projSpeed * Time.deltaTime);

        if(lowDespawn > transform.position.z || transform.position.z > topDespawn){
        Destroy(gameObject);
        }
    }
}
