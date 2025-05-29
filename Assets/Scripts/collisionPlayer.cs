using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionPlayer : MonoBehaviour
{
    public GameObject resetPoint;
    [SerializeField] GameObject _joueur;
    [SerializeField] AudioSource _PlayerHitSound;
    [SerializeField] GameObject _perduPoints;

    void Start()
    {
        _joueur = GameObject.Find("PlayerArmature");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == _joueur)
        {
            CharacterController cc = collision.gameObject.GetComponent<CharacterController>();
            if (cc != null)
            {
                _perduPoints.SetActive(true);
                Invoke("bye", 4f);
                cc.enabled = false;
                collision.transform.position = resetPoint.transform.position;
                cc.enabled = true;
                _PlayerHitSound.Play();
                FindObjectOfType<Game>()._inventaireActuel = 0;
                inventaireUI.instance.Dumped();
            }
        }
    }
    
    private void bye(){
        _perduPoints.SetActive(false);
    }
}