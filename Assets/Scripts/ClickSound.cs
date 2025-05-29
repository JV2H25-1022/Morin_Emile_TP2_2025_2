using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSound : MonoBehaviour
{
    [SerializeField] AudioSource _ClickSound;
    public void Awake()
    {
        _ClickSound.Play();
    }
}
