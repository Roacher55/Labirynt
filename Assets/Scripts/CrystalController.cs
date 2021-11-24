using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrystalController : MonoBehaviour
{
    // Start is called before the first frame update
    private List<Crystal> crystals = new List<Crystal>();
    int score = 0;
    [SerializeField] Text textScore;
    [SerializeField] GameObject crystalPrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScore()
    {
        score++;
        textScore.text = "Crystals : " + score;
    }

    public void AddCrystalToList(Crystal crystal)
    {
        crystals.Add(crystal);
    }

    public void RemoveCrystalFromList(Crystal crystal)
    {
        crystals.Remove(crystal);
    }

    public void SpawnCrystals(int countCrystals)
    {
        for (int i = 0; i < countCrystals; i++)
        {
            SpawnCrystal();
        }
    }

    private void SpawnCrystal()
    {
        GameObject tempCrystal = Instantiate(crystalPrefab);
        tempCrystal.transform.position = new Vector3(Random.Range(0f, 400f), 4f, Random.Range(0f, 400f));
    }
}
