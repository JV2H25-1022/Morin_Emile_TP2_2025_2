using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class losespeed : MonoBehaviour
{
    [SerializeField] GameObject _Trash;
    private void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Player")){
            if (gameObject.tag == "Pickable" || gameObject.tag == "Key"){
                    _Trash.SetActive(false);
                    noSpeed();
                    Invoke(nameof(Speed), 5f);
                }

            if (gameObject.tag == "notPickable"){
                    Debug.Log("nononon");
                }
            }
        }
        public void noSpeed(){ 
            FindObjectOfType<StarterAssets.ThirdPersonController>().MoveSpeed = 5f;
            FindObjectOfType<StarterAssets.ThirdPersonController>().SprintSpeed = 5f;
        }
        public void Speed(){ 
            FindObjectOfType<StarterAssets.ThirdPersonController>().MoveSpeed = 5f;
            FindObjectOfType<StarterAssets.ThirdPersonController>().SprintSpeed = 10f;
        }
}
