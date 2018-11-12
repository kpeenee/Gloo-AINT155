using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveTowards : MonoBehaviour {
    public float speed = 0.5f;
    Transform target;
    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        
	}

    private void FixedUpdate()
    {
        Vector2 direction;

        target = GameObject.FindGameObjectWithTag("Player").transform;
        direction = new Vector2(-(transform.position.x - target.position.x)* speed, -(transform.position.y - target.position.y)*speed);

        rb.velocity = direction;

    }
}
