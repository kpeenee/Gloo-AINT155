using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZombie : MonoBehaviour {
    public float timeBtwSpawn = 0;
    public float startTimeBtwSpawn = 5;
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
	}
}
