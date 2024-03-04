using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_summoner : MonoBehaviour
{
    public GameObject obstacle_target;
    int balls = 0;
    int wait_time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(balls <= 10 && Time.time > wait_time)
        {
            spawner();
        }
    }

    void spawner(){
        Vector3 spawnpos = new Vector3(Random.Range(-9f,9f),8,Random.Range(-9f,9f));
        Instantiate(obstacle_target,spawnpos,Quaternion.Euler(0,0,0));
        balls += 1;
        wait_time ++;
    }
}
