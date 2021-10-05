using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnner : MonoBehaviour
{
    [SerializeField] GameObject[] obstaclePattern;
    [SerializeField] float timeBtwSpawn;
    [SerializeField] float startTimeBtwSpawn;
    [SerializeField] float minTimeBtwSpawn;
    [SerializeField] float reduceTime;




    
    void Update()
    {
        Spawn();
    }

    void Spawn()
    {
        if ( timeBtwSpawn <= 0)                                 //if its time to spawn ok, else reduce the timer by Time.deltaTime
        {
            int rand = Random.Range(0, obstaclePattern.Length);
            Debug.Log(obstaclePattern[rand]+" is spawnned");
            Instantiate(obstaclePattern[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
            if ( startTimeBtwSpawn > minTimeBtwSpawn)
            {
                startTimeBtwSpawn -= reduceTime;
            }
        }

        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
