using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EnemyHealthBar : MonoBehaviour
{
    public Enemy_health bossHealth;
    public Slider slider;

    void Start()
    {
        slider.maxValue = bossHealth.maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = bossHealth.currentHealth;
    }
}
