using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bush : MonoBehaviour


{
    BushController bushController;
    [SerializeField] List<GameObject> fruitPrefabs;
    bool enterBush = false;
    



    // Start is called before the first frame update
    void Start()
    {
        bushController = FindObjectOfType<BushController>();
        bushController.AddBushlToList(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (enterBush)
        {

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                enterBush = false;
                //  bushController.AddScore();
                bushController.RemoveBushFromList(this);
                Invoke("Spawn", 1f);
            }

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            enterBush = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            enterBush = false;
        }
    }

    void Spawn()
    {
        GameObject tempFruit = Instantiate(fruitPrefabs[Random.Range(0,fruitPrefabs.Count)]);
        tempFruit.transform.position = new Vector3(transform.position.x, transform.position.y+1, transform.position.z);
        Destroy(gameObject);
    }


}
