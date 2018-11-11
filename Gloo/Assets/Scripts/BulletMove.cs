using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {
    public float speed = 10.0f;
    Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}

    private void FixedUpdate()
    {
        rb.velocity = transform.up * speed;
    }
}
