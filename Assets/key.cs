using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class key : MonoBehaviour
{
    public GameObject tmpCanvas;
    [SerializeField] AudioSource _PickKey;

    private void OnTriggerEnter(Collider other)
    {
        tmpCanvas.SetActive(true);
        _PickKey.Play();
        Invoke("bye", 4f);

    }

    private void bye(){
        Destroy(tmpCanvas);
    }

}
