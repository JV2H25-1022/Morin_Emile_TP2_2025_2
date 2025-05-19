using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class temps : MonoBehaviour
{
    public TMP_Text _tempsRestant;

    void Update()
    {
        float secondes = tempsRestant._time;   
        _tempsRestant.text = secondes.ToString();
        if(secondes == 0){
            SceneManager.LoadScene(3);
        }
    }
}
