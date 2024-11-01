using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    public float horizontalInput;
    public float speed;
    public Vector3 pos = new Vector3(0, 0, -10);
    public GameObject pizzaProj;
    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.position = pos.x * Vector3.right;
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        pos.x =  Mathf.Clamp(transform.position.x, -24f, 24f);
        if (Input.GetKeyDown(KeyCode.Space)){
            Instantiate(pizzaProj, transform.position, pizzaProj.transform.rotation);
        }
    }
}
