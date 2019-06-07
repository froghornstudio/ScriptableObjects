using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu]
public class PlayerRunTimeInfo : ScriptableObject
{

    [Header("Runtime Game Values")]

    //Current Save Slot
    public int current_save_slot;

    //Player1
    public int player1_current_health;
    public int player1_max_health;
    //Player2
    public int player2_current_health;
    public int player2_max_health;

}