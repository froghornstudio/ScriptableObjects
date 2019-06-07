using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public PlayerRunTimeInfo PlayerRunTimeInfo;

    private Text text;

    private void Awake() {
        text = GetComponent<Text>();
    }

    void Update() {
        text.text = PlayerRunTimeInfo.player1_current_health.ToString() + "\n";
        text.text += PlayerRunTimeInfo.player1_max_health.ToString() + "\n";
        text.text += PlayerRunTimeInfo.player2_current_health.ToString() + "\n";
        text.text += PlayerRunTimeInfo.player2_max_health.ToString() + "\n";
    }
}
