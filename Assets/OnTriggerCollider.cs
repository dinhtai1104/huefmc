using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTriggerCollider : MonoBehaviour
{
    private GameObject highLightObj;
    private bool isTrigger = false;
    public UnityEvent actionCallbackEnter;
    public UnityEvent actionCallbackExit;

    private void OnValidate()
    {
        highLightObj = transform.GetChild(0).gameObject;
    }
    
    public void SetHighLight(bool active)
    {
        highLightObj.SetActive(active);
        if (active)
        {
            actionCallbackEnter?.Invoke();
        } else
        {
            actionCallbackExit?.Invoke();
        }
    }

    public void Callback()
    {

    }
}
