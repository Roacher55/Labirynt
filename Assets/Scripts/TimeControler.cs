using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeControler : MonoBehaviour
{
    [SerializeField] private Light sun;
    [SerializeField] private GameObject clouds;
    [SerializeField] private GameObject star;
    [SerializeField] private GameObject rain;
    [SerializeField] Material cloudRainHightMaterial;
    [SerializeField] Material cloudRainLowMaterial;
    private Material cloudHightMaterial;
    private Material cloudLowMaterial;
    private Renderer cloudHightObjectRenderer;
    private Renderer cloudLowObjectRenderer;
    float dayInSecunds = 86400f;
    float randomWeather;
    float timer = 0;
    float weatherChangeCondition = 5f;
    bool rainRenderSetting  = false;
    Flare flare;
    CrystalController crystalController;
    BushController bushController;
    bool newDay = true;

    private void Start()
    {
        randomWeather = Random.Range(0f, 10f);
        flare = sun.flare;
        cloudLowObjectRenderer = clouds.transform.GetChild(0).gameObject.GetComponent<Renderer>();
        cloudHightObjectRenderer = clouds.transform.GetChild(1).gameObject.GetComponent <Renderer>();
        cloudLowMaterial = cloudLowObjectRenderer.material;
        cloudHightMaterial = cloudHightObjectRenderer.material;
        crystalController = FindObjectOfType<CrystalController>();
        bushController = FindObjectOfType<BushController>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(4f * Time.deltaTime,0f,0f);
        

        if(transform.rotation.eulerAngles.x >= 0f && transform.rotation.eulerAngles.x <= 180f)
        {
            if(rainRenderSetting)
            {
                RenderSettings.ambientIntensity = 0.7f;
                sun.enabled = false;
            }
            else
            {
                RenderSettings.ambientIntensity = 1f;
                sun.enabled = true;
            }
            
            
           // clouds.SetActive(true);
            star.SetActive(false);

            if(newDay)
            {
                crystalController.SpawnCrystals(Random.Range(2, 10));
                bushController.SpawnBush(Random.Range(2, 10));
                newDay = false;
            }
        }
        else
        {
            RenderSettings.ambientIntensity = 0.2f;
            sun.enabled = false;
         //   clouds.SetActive(false);
            star.SetActive(true);
            newDay = true;
        }

        ChangeWeather();

    }

    void ChangeWeather()
    {
        timer += Time.deltaTime;
        
        if (randomWeather < 5 && timer > weatherChangeCondition)
        {
            CloudsWeather();
        }
        else if (randomWeather >= 5 && randomWeather < 8 && timer > weatherChangeCondition)
        {
            SunnyWeather();
        }
        else if (randomWeather >= 8 && timer > weatherChangeCondition)
        {
            RainWeather();
        }
    }

    void CloudsWeather()
    {
            clouds.SetActive(true);
            rain.SetActive(false);
            timer = 0f;
            randomWeather = Random.Range(0f, 10f);
            sun.flare = null;
            cloudHightObjectRenderer.material = cloudHightMaterial;
            cloudLowObjectRenderer.material = cloudLowMaterial;
            rainRenderSetting = false;
     }

     void SunnyWeather()
     {
            clouds.SetActive(false);
            rain.SetActive(false);
            timer = 0f;
            randomWeather = Random.Range(0f, 10f);
            sun.flare = flare;
            rainRenderSetting = false;
     }

     void RainWeather()
      {
            clouds.SetActive(true);
            rain.SetActive(true);
            timer = 0f;
            randomWeather = Random.Range(0f, 10f);
            cloudHightObjectRenderer.material = cloudRainHightMaterial;
            cloudLowObjectRenderer.material = cloudRainLowMaterial;
            sun.flare = null;
            if (transform.rotation.eulerAngles.x >= 0f && transform.rotation.eulerAngles.x <= 180f)
                {
                    rainRenderSetting = true;
                }
      }
}
