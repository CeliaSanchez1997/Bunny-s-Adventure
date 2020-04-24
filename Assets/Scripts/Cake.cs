using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cake : MonoBehaviour
{

    public GameObject healthEffect;
    public int healthBoost;
    player_health_test player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<player_health_test>();
    }


    public void Use()
    {
        Instantiate(healthEffect, player.transform.position, Quaternion.identity);
        player.health += healthBoost;
        Destroy(gameObject);
    }
}
