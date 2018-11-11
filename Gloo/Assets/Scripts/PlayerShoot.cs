using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
    public GameObject bullet;
    public float timeBtwShots;
    public float startTimeBtwShots = 1.5f;
    public Transform shootPoint;

	// Use this for initialization
	void Start () {
        timeBtwShots = startTimeBtwShots;
	}
	
	// Update is called once per frame
	void Update () {

        timeBtwShots -= Time.deltaTime;
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
	}


    void Shoot()
    {
        if (timeBtwShots <= 0)
        {
            Instantiate(bullet, shootPoint.position, shootPoint.rotation);
            timeBtwShots = startTimeBtwShots;
        }
    }
}
