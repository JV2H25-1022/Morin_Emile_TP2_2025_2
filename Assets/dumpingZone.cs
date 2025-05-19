using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dumpingZone : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<Game>()._inventaireActuel = 0;
            inventaireUI.instance.Dumped();
        }
    }
}
