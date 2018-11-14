using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {
    public float speed = 10.0f;
    Rigidbody2D rb;
    public int damage = 25;
    public float lifeSpan = 5.0f;
    public GameObject collisionEffect;

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

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.tag == "Enemy")
        {
            hitInfo.GetComponent<EnemyHealthSytem>().TakeDamage(damage);
        }
        Instantiate(collisionEffect, gameObject.transform.position, gameObject.transform.rotation);
        Destroy(gameObject);
    }
}
