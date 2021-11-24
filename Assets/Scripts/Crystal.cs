using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour
{
    CrystalController crystalController;

    private void Start()
    {
        crystalController = FindObjectOfType<CrystalController>();
        crystalController.AddCrystalToList(this);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            crystalController.AddScore();
            crystalController.RemoveCrystalFromList(this);
            Destroy(gameObject);
        }
    }
}
