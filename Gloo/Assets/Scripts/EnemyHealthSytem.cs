using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthSytem : MonoBehaviour {
    public int health = 100;
    public GameObject deathEffect;
    public int scoreGain;
    public GameObject powerUp;
    

public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        float chance = Random.Range(0f, 100f);
        if(chance >= 70)
        {
            Instantiate(powerUp, transform.position, Quaternion.identity);
        }
        GameManager.playerScore += scoreGain;
        Instantiate(deathEffect, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);

    }
}
