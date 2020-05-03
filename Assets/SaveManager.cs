using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Save();
        }
    }

    private void Save()
    {
        try
        {
            BinaryFormatter bf = new BinaryFormatter();

            FileStream file = File.Open(Application.persistentDataPath + "/" + "SaveTest.dat",FileMode.OpenOrCreate);

            SaveData data = new SaveData();

            SavePLayer(data);

            file.Close();
        }
        catch(System.Exception)
        {
            //Handling errors
        }
    }

    private void SavePLayer(SaveData data)
    {
        //data.MyPlayerData = new PlayerData(Player.MyInstance.MyLevel);
    }
}
