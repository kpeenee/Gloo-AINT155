using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {
    public int speed;
    public float lifeSpan;

    private Rigidbody2D rb;




	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        
    }

    private void FixedUpdate()
    {
        rb.velocity = transform.up * speed;
        lifeSpan -= Time.deltaTime;
        if (lifeSpan <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.playerHealth -= 20;
        Destroy(gameObject);
    }
}
