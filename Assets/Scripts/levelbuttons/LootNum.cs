using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LootNum : MonoBehaviour
{
    public GameObject LevelWin;
    bool gameHasEnded = false;
    public static LootNum instance;
    public Text text;
    int num;

    UHandler uHandler;

    //varaibles for win
    public int score_num;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void ChangedLootNum(int lootValue)
    {
        num += lootValue;
        text.text = "X" + num.ToString();

        if(num == score_num)
        {
            Win();
        }
    }

    public void Win()
    {
        LevelWin.SetActive(true);
        Time.timeScale = 0;
        gameHasEnded = true;
        Debug.Log("level clear");
    }
}
