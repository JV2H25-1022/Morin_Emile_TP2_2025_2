using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotation : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 100f;
    private Vector3 randomRotationAxis;

    void Start()
    {
        randomRotationAxis = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        randomRotationAxis.Normalize();
    }

    void Update()
    {
        transform.Rotate(randomRotationAxis * rotationSpeed * Time.deltaTime);
    }
}
