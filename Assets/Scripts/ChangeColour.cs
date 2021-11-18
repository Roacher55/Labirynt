using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColour : MonoBehaviour
{
    bool changeColour = false;
    Text text;
    float timer = 0f;


    private void Start()
    {
        text = GetComponent<Text>();
        text.color = Color.green;
    }
    // Update is called once per frame
    void Update()
    {
        if(timer>1f)
        { 
            if(changeColour)
            {
                text.color = Color.green;
                changeColour = !changeColour;
            }
            else
            {
                text.color = Color.red;
                changeColour = !changeColour;
            }
            timer = 0f;
        }
        timer += Time.deltaTime;
    }
}
