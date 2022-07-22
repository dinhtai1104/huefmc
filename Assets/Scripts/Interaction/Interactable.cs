using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public UnityEvent onInteractEvent;
    public UnityEvent onDisableInteractEvent;

    public void OnInteract()
    {
        onInteractEvent?.Invoke();
    }

    public void OnRelease()
    {
        onDisableInteractEvent?.Invoke();
    }
}
