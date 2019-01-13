using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

    public float duration = 5.0f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(FireRateIncrease(collision));
        }
    }

    IEnumerator FireRateIncrease(Collider2D player)
    {
        PlayerShoot shoot = player.GetComponent<PlayerShoot>();
        shoot.startTimeBtwShots = 0.1f;

        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<BoxCollider2D>().enabled = false;

        yield return new WaitForSeconds(duration);

        shoot.startTimeBtwShots = 0.5f;

        Destroy(gameObject);
    }
}
