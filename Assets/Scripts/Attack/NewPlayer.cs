using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayer : MonoBehaviour
{

    public GameObject stick;
    public Transform point;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            shoot();
        }
    }

    void shoot()
    {
        Instantiate(stick, point.position, point.rotation);
    }
}
