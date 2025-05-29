using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class musique : MonoBehaviour
{
    public static musique instance;
    private AudioSource music;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            music = GetComponent<AudioSource>();
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (music == null) return;

        if (scene.buildIndex == 3)
        {
            music.Stop();
        }
        else if (scene.buildIndex == 0)
        {
            music.Stop();
            music.Play();
        }
        else
        {
            if (!music.isPlaying)
            {
                music.Play();
            }
        }
    }
}
