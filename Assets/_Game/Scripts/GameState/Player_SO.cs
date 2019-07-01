using UnityEngine;

//[CreateAssetMenu]
public class Player_SO : ScriptableObject
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

    public string favColor;
}