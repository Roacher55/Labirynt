using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TranslateText : MonoBehaviour
{
    public Text displayText;
    public string english;
    public string polish;
    TranslateController translateController;
    private void Awake()
    {
        translateController = FindObjectOfType<TranslateController>();
    }

    private void OnEnable()
    {
        SetTranslateText();
        translateController.onLangauageChange.AddListener(SetTranslateText); // zasubskrybowanie
    }

    private void OnDisable()
    {
        translateController.onLangauageChange.RemoveListener(SetTranslateText); // odjêcie subskryncji
    }

    private void SetTranslateText() //widz
    {
        switch (translateController.playerSettings.language)
        {
            case Language.English:
                displayText.text = english;
                break;
            case Language.Polish:
                displayText.text = polish;
                break;
        }
    }
}
