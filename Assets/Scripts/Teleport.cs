using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform player;
    public Transform targetObject;  

    private void OnTriggerEnter(Collider other)
    {
        player.position = targetObject.position;
    }

    public void TeleportButton()
    {
        player.position = targetObject.position;
    }
    
}
