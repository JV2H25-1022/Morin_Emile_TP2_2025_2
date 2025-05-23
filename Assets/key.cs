using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class key : MonoBehaviour
{
    public GameObject tmpCanvas;

    private void OnTriggerEnter(Collider other)
    {
        tmpCanvas.SetActive(true);
        Invoke("bye", 4f);

    }

    private void bye(){
        tmpCanvas.SetActive(false);
    }

}
