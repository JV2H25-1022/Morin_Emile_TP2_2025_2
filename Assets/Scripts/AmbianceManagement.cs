using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class AmbianceManagement : MonoBehaviour {
    [SerializeField] AudioMixer _mixer;
    
    public void ChangerVolumeMusique(float nouveauVolume)
    {
        Debug.Log("Changer volume" + nouveauVolume);
        _mixer.SetFloat("SonAmbiance", nouveauVolume);
    }

}