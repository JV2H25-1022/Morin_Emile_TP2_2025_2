using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trucsTotal : MonoBehaviour
{
    public int objetsPris;
    public static trucsTotal Instance;
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
    public void IncrementObjetsPris()
    {
        objetsPris += 1;
    }
}
    
