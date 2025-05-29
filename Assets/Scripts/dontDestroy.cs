using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestroy : MonoBehaviour
{
    public static dontDestroy Instance;

    public int objetTotalPris = 0;

    void Awake()
    {

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            objetTotalPris = 0;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
