using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerTrigger : MonoBehaviour
{
    public UnityEvent OnTriggered;

    public void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<FirstPersonController>();
        if (player != null)
        {
            OnTriggered?.Invoke();
        }
    }
}
