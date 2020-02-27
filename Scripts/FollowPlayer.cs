using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public bool isFliiped = false;

    public void LookAtPlayer()
    {
        Vector3 flipped = transform.localScale;
        flipped.z *= -1f;

        if(transform.position.x > player.position.x && isFliiped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFliiped = false;
        }
        else if (transform.position.x < player.position.x && isFliiped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFliiped = true;
        }
    }
}
