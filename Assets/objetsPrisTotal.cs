using UnityEngine;
using TMPro;

public class objetsPrisTotal : MonoBehaviour
{
    public static objetsPrisTotal instance;

    public int inventaireTenu;
    public TMP_Text _totalTexte;
    public GameObject truc;
    public int total;

    void Start()
    {
       total = FindObjectOfType<trucsTotal>().objetsPris;
    }

    void Update()
    {
        if ( _totalTexte != null)
        {
            _totalTexte.text = total.ToString();
        }
    }
}
