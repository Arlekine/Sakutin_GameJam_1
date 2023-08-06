using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private KeyCode _interactionButton;
    [SerializeField] private bool _canInteractOnStart;
    [SerializeField] private float _raycastDistance = 3f;

    private Interactable _selectedInteractable;

    public bool CanInteract
    {
        get;
        set;
    }

    private void Start()
    {
        CanInteract = _canInteractOnStart;
    }

    private void Update()
    {
        if (CanInteract)
        {
            var screenCenter = new Vector3Int(Screen.width / 2, Screen.height / 2);
            var ray = _camera.ScreenPointToRay(screenCenter);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, _raycastDistance))
            {
                var interactable = hit.collider.GetComponent<Interactable>();
                if (interactable != null)
                {   
                    _selectedInteractable = interactable;

                    if (Input.GetKeyDown(_interactionButton))
                    {
                        _selectedInteractable.Interact();
                    }
                }
                else
                {
                    _selectedInteractable = null;
                }
            }
            else
            {
                _selectedInteractable = null;
            }
        }
    }
}