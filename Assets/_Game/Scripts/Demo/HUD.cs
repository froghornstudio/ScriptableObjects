using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    //Current Player Scriptable Object
    public Player_SO Player_SO;

    private Text text;

    private void Awake() {
        text = GetComponent<Text>();
    }

    void Update() {
        text.text = "";
        foreach (var field in typeof(Player_SO).GetFields(BindingFlags.Public | BindingFlags.Instance)) {
            text.text += "field: " + field.Name + " value: " + field.GetValue(Player_SO).ToString() + "\n";           
        }

    }
}
