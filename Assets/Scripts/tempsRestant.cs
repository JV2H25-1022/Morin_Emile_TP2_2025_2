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
            return;
        }

        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.buildIndex == 1)
        {
            this.enabled = true;
            _time = 60.0f;
            Debug.Log("tempsRestant ENABLED in scene 1");
        }
        else if (scene.buildIndex == 3)
        {
            this.enabled = false;
        }
    }

    private void Update()
    {
        _time -= Time.deltaTime;
        if (_time <= 0)
        {
            SceneManager.LoadScene(3);
            this.enabled = false;
            _time = 60.0f;
        }
    }
}
    
    
