using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Block : MonoBehaviour
{
    [SerializeField] int points = 100;
    [SerializeField] AudioSource audioSource;

    Rigidbody rb;
    bool destroyed;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Kill") && rb.velocity.magnitude == 0 && rb.angularVelocity.magnitude == 0)
        {
            destroyed = true; 
            //int 
        }
    }
}
