using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest_Enemy_health : MonoBehaviour
{
    public string enemyQuestName;
    private QuestManager theQM;

    public int maxHealth = 100;
    public int currentHealth;
    public GameObject deathEffect;
    public bool drop;
    public GameObject theDrop;
    public Animator animator;

    public void Start()
    {
        currentHealth = maxHealth;
        theQM = FindObjectOfType<QuestManager>();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            theQM.enemyKilled = enemyQuestName;
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
