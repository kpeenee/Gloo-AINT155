using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpawner : MonoBehaviour {

    public float timeBtwSpawn = 0f;
    public float startTimeBtwSpawn = 2f;

    public GameObject[] spawners = new GameObject[2];
    int index;

    private void Start()
    {
        timeBtwSpawn = startTimeBtwSpawn;
    }

    // Update is called once per frame
    void Update () {
        index = Random.Range(0, spawners.Length);

        if (timeBtwSpawn <= 0)
        {
            Instantiate(spawners[index], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
        }

        timeBtwSpawn -= Time.deltaTime;
	}
}
