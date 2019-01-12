using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {
    public int speed;
    public float lifeSpan;

    private Transform target;




	// Use this for initialization
	void Start () {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position,speed * Time.deltaTime);
        if (lifeSpan <= 0)
        {
            Destroy(gameObject);
        }
        lifeSpan -= Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameManager.playerHealth -= 20;
        }
        
        Destroy(gameObject);
    }
}
