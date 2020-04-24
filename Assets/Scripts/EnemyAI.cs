using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Animator animator;
    int maxhealth = 100;
    public int health;
    public GameObject deathEffect;
    //Only if its a boss
    //public bool isInvulnerable = false;


    void Start()
    {
        health = maxhealth;
    }

    public void TakeDamage(int damage)
    {
        //Only if its a boss
        //if(isInvulnerable)
        //return
        health -= damage;

        if(health <= 0)
        {
            Die();
        }
        //Only if its a boss
        //if(health <= 200)
        //GetComponent<Animator>().SetBool("isEnraged",true);

    }

    public void Die()
    {
        
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
