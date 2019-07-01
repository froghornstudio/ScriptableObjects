using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public Player_SO Player_SO;

    public int current_health1, max_health1;

    private void get_Player_SO() {
        current_health1 = Player_SO.player1_current_health;
        max_health1 = Player_SO.player1_max_health;
    }

    private void OnEnable() {
        get_Player_SO();
    }

    private void Update() {
        get_Player_SO();
    }

}
