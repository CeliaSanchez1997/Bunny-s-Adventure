using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_health : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;
    public GameObject deathEffect;
    public bool drop;
    public GameObject theDrop;
    public Animator animator;

    public void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        animator.SetTrigger("Die");
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        if (drop) Instantiate(theDrop, transform.position, transform.rotation);
        
    }
}
