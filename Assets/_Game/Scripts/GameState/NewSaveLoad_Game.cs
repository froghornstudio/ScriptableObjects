using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class NewSaveLoad_Game : MonoBehaviour {

    //Player Scriptable Object Default settings
    public Player_SO Player_SO_defaults;

    //Current Player Scriptable Object
    public Player_SO Player_SO;

    public void NewGame(int slotNum) {
        //Load default template into json then overwrite current SO with default
        var jsonTemplate = JsonUtility.ToJson(Player_SO_defaults);
        JsonUtility.FromJsonOverwrite(jsonTemplate, Player_SO);

        //Save game using current slot
        SaveGame(slotNum);
    }

    public void SaveGame(int slotNum) {
        //Setup binary formatter and path to data file
        BinaryFormatter bf = new BinaryFormatter();
        string mySlotString = Application.persistentDataPath + "/playerInfo"+slotNum.ToString()+".dat";

        //Write data to file
        FileStream file = File.Create(mySlotString);
        var json = JsonUtility.ToJson(Player_SO);
        bf.Serialize(file, json);
        file.Close();
    }
    
    public void LoadGame(int slotNum) {
        //Set mySlotString to current path of data file requested by argument slotNum
        string mySlotString = Application.persistentDataPath + "/playerInfo" + slotNum.ToString() + ".dat";

        //If file exists, load file
        if (File.Exists(mySlotString)) {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(mySlotString, FileMode.Open);
            JsonUtility.FromJsonOverwrite((string)bf.Deserialize(file), Player_SO);
            file.Close();
        }
    }

    //Delete saved game file.
    public void DeleteGame(int slotNum) {
        //Set mySlotString to current path of data file requested by argument slotNum
        string mySlotString = Application.persistentDataPath + "/playerInfo" + slotNum.ToString() + ".dat";

        try {
            if (File.Exists(mySlotString)) {
                File.Delete(mySlotString);
            }
        }
        catch (Exception ex) {
            Debug.LogException(ex);
        }
    }

}
