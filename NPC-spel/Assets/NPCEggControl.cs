using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCEggControl : MonoBehaviour
{
    private bool canInteract = false;

    void Update()
    {
        if(canInteract && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Bajsapa");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canInteract = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canInteract = false;
        }
    }
}
