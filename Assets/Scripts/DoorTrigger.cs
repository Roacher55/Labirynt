using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public GameObject doors;
    private Animator animator;
    private MeshRenderer[] meshRenderer;
    public Material materialOnTrigger;
    public  Material materialEndTrigger;

    bool doorOpen = false;
    bool playerInTrigger = false;
    public GameObject interactionText;

    private void Start()
    {
        animator = doors.GetComponent<Animator>();
        meshRenderer = doors.GetComponentsInChildren<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInTrigger && Input.GetKeyDown(KeyCode.E))
        {
            doorOpen = !doorOpen;
            animator.SetBool("Open", doorOpen); 
        }

        

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            playerInTrigger = true;
            interactionText.SetActive(true);
            foreach(var m in meshRenderer)
            {
                m.material = materialOnTrigger;
            }
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerInTrigger = false;
            interactionText.SetActive(false);
            foreach (var m in meshRenderer)
            {
                m.material = materialEndTrigger;
            }
        }
    }
}
