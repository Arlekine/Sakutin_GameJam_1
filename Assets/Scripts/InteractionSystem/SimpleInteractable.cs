using UnityEngine.Events;

public class SimpleInteractable : Interactable
{
    public UnityEvent OnInteracted;

    protected override void OnInteract()
    {
        OnInteracted?.Invoke();
    }
}