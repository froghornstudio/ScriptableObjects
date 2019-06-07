using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public PlayerRunTimeInfo PlayerRunTimeInfo;

    private int current_health1, max_health1;

    private void get_PlayerRunTimeInfo() {
        current_health1 = PlayerRunTimeInfo.player1_current_health;
        max_health1 = PlayerRunTimeInfo.player1_max_health;
    }

    private void OnEnable() {
        get_PlayerRunTimeInfo();
    }

    private void Update() {
        get_PlayerRunTimeInfo();
    }

}
