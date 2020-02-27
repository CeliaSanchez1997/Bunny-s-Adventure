using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stick : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 10;
    public Rigidbody2D rd;
    //public GameObject impactEffect;


    // Start is called before the first frame update
    void Start()
    {
        rd.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        EnemyAI enemy = hitInfo.GetComponent<EnemyAI>();
        if(enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        //Instantiate(impactEffect, transform.position,transform.rotation);

        Destroy(gameObject);
    }
}
