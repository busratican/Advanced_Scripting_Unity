using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float maxSpeed = 1f; // m/s
    private Transform objectTransform = null;
    
    private void Awake() 
    {
        objectTransform = GetComponent<Transform>();
        
    }

    void Update()
    {
        objectTransform.position += objectTransform.forward * maxSpeed;
    }
}
