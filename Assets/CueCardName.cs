using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CueCardName : MonoBehaviour
{
    public TMP_Text nameText;

    void Start()
    {
        string NomJoueur = NomDuJoueur.Instance.NomFinal();
        nameText.text = NomJoueur;
    }
}
