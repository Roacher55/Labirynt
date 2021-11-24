using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BushController : MonoBehaviour
{
    private List<Bush> bushes = new List<Bush>();
    private List<Fruit> fruites = new List<Fruit>();
    int score = 0;
    [SerializeField] Text textScore;
    [SerializeField] GameObject bushPrefab;
    // Start is called before the first frame update
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
        textScore.text = "Fruits : " + score;
    }

    public void AddBushlToList(Bush bush)
    {
        bushes.Add(bush);
    }

    public void RemoveBushFromList(Bush bush)
    {
        bushes.Remove(bush);
    }

    public void AddFruitToList(Fruit fruit)
    {
        fruites.Add(fruit);
    }

    public void RemoveFruitFromList(Fruit fruit)
    {
        fruites.Remove(fruit);
    }

    public void SpawnBush(int countBush)
    {
        for (int i = 0; i < countBush; i++)
        {
            SpawnBush();
        }
    }

    private void SpawnBush()
    {
        GameObject tempBush = Instantiate(bushPrefab);
        tempBush.transform.position = new Vector3(Random.Range(0f, 400f), 4f, Random.Range(0f, 400f));
    }

    
}
