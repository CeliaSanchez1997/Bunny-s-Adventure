using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class SaveData
{
    public PlayerData MyPlayerData { get; set; }

    public SaveData()
    {

    }
}

[SerializeField]
public class PlayerData
{
    public int MyLevel { get; set; }

    public PlayerData(int level)
    {
        this.MyLevel = level;
    }
}

