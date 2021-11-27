using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName ="PlayerSettings")]
public class PlayerSettings : ScriptableObject
{
    public float soundVolume;
    public float musicVolume;
    public float mouseSensitivity;
    public float fieldOfView;
    public Language language;
    public Resolution resolution;

}

public enum Language
{
    English, Polish
}

public enum Resolution
{
    R_1280x720, R_1920x1080, R_2160x1080, R_3840x2160
}
