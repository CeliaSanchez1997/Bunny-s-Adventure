using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    public Transform pfHealthBar;

    // Start is called before the first frame update
    private void Start()
    {
        BarHealthSystem healthSystem = new BarHealthSystem(100);

        Transform healthBarTransform = Instantiate(pfHealthBar, new Vector3(0,10), Quaternion.identity);
        HealthBar healthBar = healthBarTransform.GetComponent<HealthBar>();
        healthBar.SetUp(healthSystem);

    }
}
