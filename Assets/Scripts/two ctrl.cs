using UnityEngine;

public class DoubleClickTrigger : MonoBehaviour
{
    // —сылка на GameManager
    public GameManager _GameManager;

    private bool playerInZone = false;
    private bool doubleCtrlPressed = false;
    private float timeSinceLastClick;

    private void Update()
    {
        if (playerInZone && Input.GetKeyDown(KeyCode.LeftControl)&& doubleCtrlPressed == false)
            
        {
            if (Time.time - timeSinceLastClick <= _GameManager._timeBetweenClicks)
            {
                _GameManager.IncrementScore();
                doubleCtrlPressed = true;
            }
            else
            {
                timeSinceLastClick = Time.time;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInZone = true;
            timeSinceLastClick = Time.time;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInZone = false;
        }
    }
}