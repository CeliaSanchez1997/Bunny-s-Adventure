using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UHandler : MonoBehaviour
{
    public GameObject LevelDialog;
    public static UHandler instance;
    public Text youWin;

    // Start is called before the first frame update
    void awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    public void ShowLevelDialog(string v, string text)
    {
        LevelDialog.SetActive(true);
    }
}
