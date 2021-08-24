using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSoundTime : MonoBehaviour
{
    //Spawn this object
    public GameObject spawnObject;

    public float maxTime = 5;
    public float minTime = 2;

    private float soundTime;

    private float spawnTime; 

    //current time
    private float time;

    //The time to spawn the object
   

    void Start()
    {
        spawnTime = soundTime + 1;
        SetRandomTime();
        time = minTime;
    }

    void FixedUpdate()
    {

        //Counts up
        time += Time.deltaTime;

        //Check if its the right time to spawn the object
        if (time >= spawnTime)
        {
            PlaySound();
            SetRandomTime();
        }

    }


    //Spawns the object and resets the time
    void PlaySound()
    {
        time = minTime;
        Instantiate(spawnObject, transform.position, spawnObject.transform.rotation);
    }

    //Sets the random time between minTime and maxTime
    void SetRandomTime()
    {
        soundTime = Random.Range(minTime, maxTime);
    }

}
