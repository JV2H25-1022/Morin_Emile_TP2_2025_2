using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    [SerializeField] Animator _animator;
    [SerializeField] GameObject _joueur;
    [SerializeField] GameObject[] _dechets;
    [SerializeField] GameObject[] _dechetsNonPickable;
    [SerializeField] GameObject[] _Key;
    [SerializeField] int pickableCount;
    [SerializeField] int totalCount;
    [SerializeField] public int _inventaireActuel;
    [SerializeField] public int _inventaireMaximum;
    [SerializeField] public int _objetTotalPris;
    [SerializeField] AudioSource _pickUpSound;
    public TMP_InputField _NomDuJoueur;
    public static string nom;
    public Game instance;

    void Start()
    {
        _joueur = GameObject.Find("PlayerArmature");
        _animator = GameObject.Find("PlayerArmature").GetComponent<Animator>();
        
    }

    

    void Update()
    {
        // --------------- GARDER LE COMPTE DES DECHETS DANS LA SCENE ------------------
        totalCount = pickableCount - 1;
        pickableCount = GameObject.FindGameObjectsWithTag("Pickable").Length;
        if(pickableCount == totalCount){
            _animator.SetBool("PickUp", true);
            _pickUpSound.Play();
            _inventaireActuel += 1;
            _objetTotalPris += 1;
            trucsTotal.Instance.IncrementObjetsPris();
            inventaireUI.instance.dechetPris();
            totalCount -= 1;
        }
        else{
            _animator.SetBool("PickUp", false);
        }
        

        // --------------- DÉFENDRE LE JOUEUR DE PRENDRE DES OBJETS A MAX INVENTAIRE ------------------
        _dechets = GameObject.FindGameObjectsWithTag("Pickable");
        _dechetsNonPickable = GameObject.FindGameObjectsWithTag("notPickable");
        _Key = GameObject.FindGameObjectsWithTag("Key");
        if(_inventaireActuel == _inventaireMaximum){
            foreach(GameObject obj in _dechets){
                obj.tag = "notPickable"; 
            } 
        }

        else{
            foreach(GameObject obj in _dechetsNonPickable){
                obj.tag = "Pickable"; 
            }
        }
       if(pickableCount == 0 && _dechetsNonPickable.Length == 0 && _inventaireActuel == 0 && _Key.Length == 0){
            SceneManager.LoadScene(2);
        }
        
    } 
}
