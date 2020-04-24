using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player_health_test : MonoBehaviour
{
    public int health;
    public int fullHealth = 100;
    public Text healthDisplay;

    public GameObject deathEffect;


    public void Start()
    {
        health = fullHealth;
    }

    private void Update()
    {
        healthDisplay.text = health.ToString();
    }

        public void TakeDamage(int damage)
    {
        health -= damage;

        StartCoroutine(DamageAnimation());

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    IEnumerator DamageAnimation()
    {
        SpriteRenderer[] srs = GetComponentsInChildren<SpriteRenderer>();

        for (int i = 0; i < 3; i++)
        {
            foreach (SpriteRenderer sr in srs)
            {
                Color c = sr.color;
                c.a = 0;
                sr.color = c;
            }

            yield return new WaitForSeconds(.1f);

            foreach (SpriteRenderer sr in srs)
            {
                Color c = sr.color;
                c.a = 1;
                sr.color = c;
            }

            yield return new WaitForSeconds(.1f);
        }
    }
}
