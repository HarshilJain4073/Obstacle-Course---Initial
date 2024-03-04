using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{  
    [SerializeField]float movespeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xvalue= Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
        float zvalue = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;
        transform.Translate(xvalue,0,zvalue);
    }
}
