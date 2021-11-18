using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeControler : MonoBehaviour
{
    [SerializeField] private Light sun;
    [SerializeField] private GameObject clouds;
    [SerializeField] private GameObject star;
    float dayInSecunds = 86400f;
    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0042f * Time.deltaTime,0f,0f);
        

        if(transform.rotation.eulerAngles.x >= 0f && transform.rotation.eulerAngles.x <= 180f)
        {
            RenderSettings.ambientIntensity = 1f;
            sun.enabled = true;
            clouds.SetActive(true);
            star.SetActive(false);
        }
        else
        {
            RenderSettings.ambientIntensity = 0.2f;
            sun.enabled = false;
            clouds.SetActive(false);
            star.SetActive(true);
        }
    }
}
