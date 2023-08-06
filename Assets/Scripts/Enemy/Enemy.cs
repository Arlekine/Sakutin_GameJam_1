using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent<HealthSystem>(out HealthSystem player))
        {
            player.TakeHit(player.maxHealth);
        }

    }
}
