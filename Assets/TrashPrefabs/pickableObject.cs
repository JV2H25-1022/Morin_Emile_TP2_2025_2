using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickableObject : MonoBehaviour
{
    [SerializeField] GameObject _Trash;
    private void OnTriggerEnter(){
        if (gameObject.tag == "Pickable"){
                Destroy(_Trash);
            }

        if (gameObject.tag == "notPickable"){
                Debug.Log("nononon");
            }
        }
}
