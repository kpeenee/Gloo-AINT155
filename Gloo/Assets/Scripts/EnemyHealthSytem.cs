using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthSytem : MonoBehaviour {
    public int health = 100;
    public GameObject deathEffect;
    public int scoreGain;
    
    

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
        GameManager.playerScore += scoreGain;
        Instantiate(deathEffect, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);

    }
}
