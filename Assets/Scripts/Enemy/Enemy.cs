using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent<Player>(out Player player))
        {
            player.TakeDamage(1);
        }

    }
}
