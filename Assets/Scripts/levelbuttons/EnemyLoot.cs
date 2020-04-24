using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EnemyLoot : MonoBehaviour
{
    public Transform player;
    public int lootValue = 1;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            LootNum.instance.ChangedLootNum(lootValue);
            Destroy(gameObject);
        }
    }

}
