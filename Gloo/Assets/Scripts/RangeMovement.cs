using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeMovement : MonoBehaviour {
    private Animator anim;

    public float speed;
    public float stoppingDistance;
    public float retreatDistance;

    public Transform player;



	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Vector2.Distance(transform.position, player.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            anim.SetBool("isMoving", true);
        }
        else if (Vector2.Distance(transform.position, player.position) < stoppingDistance && (Vector2.Distance(transform.position, player.position) > retreatDistance))
        {
            transform.position = this.transform.position;
            anim.SetBool("isMoving", false);
        }
        else if (Vector2.Distance(transform.position, player.position) < retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
            anim.SetBool("isMoving", true);
        }

    }
}
