using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTakeDamage : MonoBehaviour {
    public float hurtTime = 1.0f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            GameManager.playerHealth -= 10;
            GetComponent<Collider2D>().enabled = false;
            Invoke("ResetCollider", hurtTime);
        }

        
    }
    private void ResetCollider()
    {
        GetComponent<Collider2D>().enabled = true;
    }
}
