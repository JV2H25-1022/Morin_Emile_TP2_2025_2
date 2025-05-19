using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class inventaireUI : MonoBehaviour
{

    public static inventaireUI instance;
    public TMP_Text _Inventaire;

    int inventaireMax = 10;
    public int inventaireTenu = FindObjectOfType<Game>()._inventaireActuel;
    void Awake()
    {
        if (instance == null)
        {
            instance = this; 
        }
        else
        {
            Destroy(gameObject); 
        }
    }

    void Start()
    {
        UpdateUI();
    }

    public void dechetPris()
    {
        inventaireTenu += 1;
        UpdateUI();
    }

    public void UpdateUI()
    {
        _Inventaire.text = inventaireTenu.ToString() + "/" + inventaireMax.ToString();
    }

    public void Dumped(){
        _Inventaire.text = 0 + "/" + inventaireMax.ToString();
        inventaireTenu = 0;
    }
}
