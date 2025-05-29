using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class objetsPrisTotal : MonoBehaviour
{
    public static objetsPrisTotal instance;

    public TMP_Text _totalTexte;
    public GameObject truc;
    public int total;

    void Start()
    {
       total = FindObjectOfType<trucsTotal>().objetsPris;
    }

    void Update()
    {
        int grosTotal = total;
        _totalTexte.text = grosTotal.ToString();
    }
}
