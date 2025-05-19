using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class NomDuJoueur : MonoBehaviour
{
    public static NomDuJoueur Instance;
    public TMP_InputField _NomDuJoueur;
    public static string nom;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void DebutJeu(){
        nom = _NomDuJoueur.text;
        Debug.Log("Nom du joueur : " + nom);
        SceneManager.LoadScene(1);
    }

    public string NomFinal(){
        return _NomDuJoueur.text;
    }
}
