﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cake : MonoBehaviour
{

    private Player player;
    public GameObject healthEffect;
    public int healthBoost;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    public void Use()
    {
        Instantiate(healthEffect, player.transform.position, Quaternion.identity);
        player.health += healthBoost;
        Destroy(gameObject);
    }
}