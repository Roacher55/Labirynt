using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TranslateController : MonoBehaviour
{
    public PlayerSettings playerSettings;
    public UnityEvent onLangauageChange; // autor

    public void ChangeLanguage()
    {
        switch (playerSettings.language)
        {
            case Language.English:
                playerSettings.language = Language.Polish;
                break;
            case Language.Polish:
                playerSettings.language = Language.English;
                break;
        }

        onLangauageChange.Invoke(); //Wrzucenie filmu

    }
}
