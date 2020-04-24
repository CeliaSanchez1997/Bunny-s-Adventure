using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    public int health = 100;
    public GameObject deathEffect;

    public void TakeDamage(int damage)
    {

        health -= damage;
        //animation
        //StartCorutine(DamageAnimation());
        if (health <= 0)
        {
            Die();
        }

    }

    public void Die()
    {
        //For right now until animation and game over screen is done
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        //Game over screen and damage
        //SceneManager.LoadScene(SceneManager.GetAxisScene().buildIndex);
        
    }

    /*IEnumerable DamageAnimation()
    {
        SpriteRenderer[] srs = GetComponentsInChildren<SpriteRenderer>();

        for(int i = 0; i < 3; i++)
        {
            foreach(SpriteRenderer sr in srs)
            {
                Color c = sr.color;
                c.a = 0;
                sr.color = c;
            }

            yield return new WaitForSeconds(.1f);*/

        }
    

