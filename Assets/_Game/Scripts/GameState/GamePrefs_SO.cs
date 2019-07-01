using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu]
public class GamePrefs_SO : ScriptableObject {

    [Header("Game Play Preferences")]
    public bool fullScreen = true;
    public string resolution = "";

    [Header("Sound Volumes")]
    public float bgMusicVolume = 1f;
    public float sfxVolume = 1f;
    public float voiceVolume = 1f;

}
