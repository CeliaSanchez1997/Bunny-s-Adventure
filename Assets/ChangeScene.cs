using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] private string newLevel;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(newLevel);
        }
    }

}
