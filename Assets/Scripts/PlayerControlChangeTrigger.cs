using UnityEngine;

public class PlayerControlChangeTrigger : MonoBehaviour
{
    [SerializeField] private KeyCode _newZoomKey;
    [SerializeField] private KeyCode _newJumpKey;
    [SerializeField] private string _newForwardAxis;
    [SerializeField] private string _newSideAxis;

    public void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<FirstPersonController>();

        if (player != null)
        {
            player.jumpKey = _newJumpKey;
            player.zoomKey = _newZoomKey;
            player.forwardAxis = _newForwardAxis;
            player.sideAxis = _newSideAxis;
        }
    }
}