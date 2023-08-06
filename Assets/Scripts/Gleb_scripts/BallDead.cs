using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BollDead : MonoBehaviour
{
    public Rigidbody targetRigidbody;


    private void Start()
    {

        targetRigidbody.useGravity = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        targetRigidbody.useGravity = true;
    }
}
