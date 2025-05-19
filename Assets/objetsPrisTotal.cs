using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class objetsPrisTotal : MonoBehaviour
{

    public static objetsPrisTotal instance;
    public int inventaireTenu;
    public TMP_Text _totalTexte;

    void Start(){
        GameObject go = GameObject.FindWithTag("ScoreFinal");
        _totalTexte = go.GetComponent<TMP_Text>();
    }
    void Update()
    {
        inventaireTenu = FindObjectOfType<Game>()._objetTotalPris + 21;
        _totalTexte.text = inventaireTenu.ToString();
    }
}
