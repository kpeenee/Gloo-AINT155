using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZombie : MonoBehaviour {
    public float timeBtwSpawn = 0;
    public float startTimeBtwSpawn = 5;
    private float startTimeBtwIncrease = 10f;
    private float timeBtwIncrease = 10f;
    public GameObject zombie;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (timeBtwSpawn <= 0)
        {
            Instantiate(zombie, gameObject.transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }

        if (timeBtwIncrease <= 0)
        {
            IncreaseFrequency();
            timeBtwIncrease = startTimeBtwIncrease;
        }

        timeBtwIncrease -= Time.deltaTime;
	}

    void IncreaseFrequency()
    {
        if(startTimeBtwSpawn > 1)
        {
            startTimeBtwSpawn -= 0.5f;
        }
    }
}
