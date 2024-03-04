using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_destroyer : MonoBehaviour
{
    public GameObject obstacle_target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(obstacle_target.transform.position.y < -1){
            Destroy(obstacle_target);
        }
    }

}
