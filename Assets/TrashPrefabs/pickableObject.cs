using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickableObject : MonoBehaviour
{
    [SerializeField] GameObject _Trash;
    private void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Player")){
            if (gameObject.tag == "Pickable" || gameObject.tag == "Key"){
                    Destroy(_Trash);
                }

            if (gameObject.tag == "notPickable"){
                    Debug.Log("nononon");
                }
            }
        }
}
