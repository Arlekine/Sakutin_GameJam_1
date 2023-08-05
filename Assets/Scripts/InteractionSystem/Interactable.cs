using UnityEngine;

[RequireComponent(typeof(Collider))]
public abstract class Interactable : MonoBehaviour
{
    [SerializeField] private bool _disableOnInteract;

    private Collider _collider;

    private void Awake()
    {
        _collider = GetComponent<Collider>();
    }

    public void Interact()
    {
        if (_disableOnInteract)
            _collider.enabled = false;

        OnInteract();
    }

    protected abstract void OnInteract();
}