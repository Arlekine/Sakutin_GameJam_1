using UnityEngine;
using UnityEngine.Events;

public class ObjectTrigger : MonoBehaviour
{
    public UnityEvent OnTriggered;

    public GameObject targetObject;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == targetObject)
        {
            OnTriggered?.Invoke();
        }
    }
}