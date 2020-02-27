using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    private BarHealthSystem healthSystem;

    public void SetUp(BarHealthSystem healthSystem)
    {
        this.healthSystem = healthSystem;

        healthSystem.OnHealthChanged += healthSystem_OnHealthChanged;
    }

    private void healthSystem_OnHealthChanged(object sender, System.EventArgs e)
    {
        transform.Find("Bar").localScale = new Vector3(healthSystem.getHealthPercent(), 1);
    }

    private void Update()
    {
        //transform.Find("Bar").localScale = new Vector3(healthSystem.getHealthPercent(),1);
    }
}
