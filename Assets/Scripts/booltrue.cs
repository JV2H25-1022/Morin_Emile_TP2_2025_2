using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class booltrue : MonoBehaviour
{
    public string parameterName; 
    [SerializeField] Animator animator;  
    [SerializeField] bool VraiOuFaux; 
    public void Start()
    {
        animator.SetBool(parameterName, true);
    }
}

