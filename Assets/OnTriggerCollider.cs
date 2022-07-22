using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerCollider : MonoBehaviour
{
    private GameObject highLightObj;
    private bool isTrigger = false;


    private void OnValidate()
    {
        highLightObj = transform.GetChild(0).gameObject;
    }
    
    public void SetHighLight(bool active)
    {
        highLightObj.SetActive(active);
    }
}
