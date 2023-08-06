using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadTriger : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        var player = other.collider.GetComponent<HealthSystem>();

        if(player != null)
        {
            player.TakeHit(player.maxHealth);
        }
    }
}
