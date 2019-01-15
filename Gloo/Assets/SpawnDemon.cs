using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDemon : MonoBehaviour {

    public float timeBtwSpawn = 0f;
    public float startTimeBtwSpawn = 10f;
    
    public GameObject demon;


   

    // Update is called once per frame
    void Update()
    {

        float ranX = Random.Range(-25f, 25);
        float ranY = Random.Range(-20f, 20f);
        Vector3 spawnPoint = new Vector3(ranX, ranY, 0);

        if (timeBtwSpawn <= 0)
        {
            Instantiate(demon, spawnPoint, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
    
}
