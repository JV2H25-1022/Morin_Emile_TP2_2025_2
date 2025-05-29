using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HereOrNot : MonoBehaviour
{
    public GameObject canvas;
    public HereOrNot Instance;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (canvas != null){
                canvas.SetActive(!canvas.activeSelf);
                Cursor.visible = true;
                            Cursor.lockState = canvas.activeSelf ? CursorLockMode.None : CursorLockMode.Locked;
                }
        }
    }
}