using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tempsRestant : MonoBehaviour
{
    public static float _time = 60.0f;
    public static tempsRestant Instance;
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
    void Update()
    {
        _time -= Time.deltaTime;
        if(_time <= 0){
            SceneManager.LoadScene(3);
            GetComponent<tempsRestant>().enabled = false;
        }
    }
}
    
    
