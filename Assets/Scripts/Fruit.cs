using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    // Start is called before the first frame update
    BushController bushController;
    void Start()
    {
        bushController = FindObjectOfType<BushController>();
        bushController.AddFruitToList(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            bushController.AddScore();
            bushController.RemoveFruitFromList(this);
            Destroy(gameObject);
        }
    }
}
