using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SaveLoad_SO : MonoBehaviour {

    //PlayerRunTimeInfo Scriptable Object Default
    public PlayerRunTimeInfo PlayerRunTimeInfo_defaults;

    //PlayerRunTimeInfo Scriptable Object
    public PlayerRunTimeInfo PlayerRunTimeInfo;

    public void NewGame(int slotNum) {
        var jsonTemplate = JsonUtility.ToJson(Resources.Load("PlayerRunTimeInfo_Defaults_SO"));
        JsonUtility.FromJsonOverwrite(jsonTemplate, PlayerRunTimeInfo);

        SaveGame(slotNum);
    }

    public void SaveGame(int slotNum) {
        BinaryFormatter bf = new BinaryFormatter();
        string mySlotString = Application.persistentDataPath + "/playerInfo"+slotNum.ToString()+".dat";

        FileStream file = File.Create(mySlotString);
        var json = JsonUtility.ToJson(PlayerRunTimeInfo);
        bf.Serialize(file, json);
        file.Close();
    }
    
    public void LoadGame(int slotNum) {
        string mySlotString = Application.persistentDataPath + "/playerInfo" + slotNum.ToString() + ".dat";

        if (File.Exists(mySlotString)) {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(mySlotString, FileMode.Open);
            JsonUtility.FromJsonOverwrite((string)bf.Deserialize(file), PlayerRunTimeInfo);
            file.Close();

        }
    }

    public void DeleteGame(int slotNum) {
        try {
            File.Delete(Application.persistentDataPath + "/playerInfo" + slotNum.ToString() + ".dat");
        }
        catch (Exception ex) {
            Debug.LogException(ex);
        }
    }

}




