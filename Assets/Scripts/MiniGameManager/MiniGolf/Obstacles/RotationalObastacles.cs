using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationalObastacles : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    private float zRotationValue = 0;
    private bool isRotateFinished = true;
    private Quaternion desiredRot;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotationBlockMovement();
    }

    private void RotationBlockMovement()
    {
        if (isRotateFinished)
        { 
            isRotateFinished = false;
            desiredRot = Quaternion.Euler(transform.rotation.x, transform.rotation.y, zRotationValue);
            transform.rotation = Quaternion.Lerp(transform.rotation, desiredRot, 1);
            zRotationValue = zRotationValue + rotationSpeed;
        }
        if (transform.rotation == desiredRot)
        {
            isRotateFinished = true;
        }
    }
}
