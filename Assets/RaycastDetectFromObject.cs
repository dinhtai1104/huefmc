using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastDetectFromObject : MonoBehaviour
{
    public LayerMask tagObject;
    public Transform raycastDirTrans;
    public float rayLength;
    public Grabblable grabblable;
    public InteractItem item;
    private OnTriggerCollider currentObjectFound = null;
    private ItemType itemType;
    private bool isFirstDetect = false;
    private float timeHold = 0;
    private void OnValidate()
    {
        item = GetComponent<InteractItem>();
        itemType = item.itemType;
    }

    private void Update()
    {
        if (!grabblable || !grabblable.isGrabbled)
        {
            timeHold = 0;
            return;
        }
        if (item.isFinished) return;
        RaycastHit hit;
        if (Physics.Raycast(raycastDirTrans.position, raycastDirTrans.forward, out hit, rayLength, tagObject))
        {
            OnTriggerCollider objectTrigger = hit.collider.GetComponent<OnTriggerCollider>();
            if (objectTrigger != null)
            {
                if (!isFirstDetect)
                {
                    isFirstDetect = true;
                    if (itemType == ItemType.OngNgheTim)
                    {
                        LogController.Instance.Log(
                            new LogData
                            {
                                ngay = DateTime.Now.ToLongTimeString(),
                                hanhDong = "Bắt đầu khám tim",
                                thoiGianThucHien = "---"
                            }
                        );
                    }
                }
                // Tại đây chúng ta phát hiện được object đã chạm vào checkpoint, và cứ check thời gian
                timeHold += Time.deltaTime;

                if (timeHold > 10) 
                {
                    if (currentObjectFound)
                    {
                        currentObjectFound.SetHighLight(false);
                        currentObjectFound = null;
                    }
                    item.InvokeDisInteractEvent();

                    if (itemType == ItemType.OngNgheTim)
                    {
                        Patient.Instance.SetTShirtActive(true);
                        LogController.Instance.Log(
                            new LogData
                            {
                                ngay = DateTime.Now.ToLongTimeString(),
                                hanhDong = "Kết thúc khám tim",
                                thoiGianThucHien = "10s"
                            }
                        );

                        UiManager.Instance.ShowMessage("Khám tim", "Nhịp tim 81, ổn định!");
                    }
                    item.isFinished = true;
                    timeHold = 0;
                    return;
                }

                if (currentObjectFound == null)
                {
                    objectTrigger.SetHighLight(true);
                    currentObjectFound = objectTrigger;
                    item.InvokeInteractEvent();
                } 
                else
                {
                    if (currentObjectFound != objectTrigger)
                    {
                        currentObjectFound.SetHighLight(false);
                        item.InvokeDisInteractEvent();
                        currentObjectFound = objectTrigger;
                        currentObjectFound.SetHighLight(true);
                        item.InvokeInteractEvent();
                    }
                }
            } 
            else
            {
                if (currentObjectFound)
                {
                    currentObjectFound.SetHighLight(false);
                    currentObjectFound = null;
                }
                item.InvokeDisInteractEvent();
            }
        }
        else
        {
            if (currentObjectFound)
            {
                currentObjectFound.SetHighLight(false);
                currentObjectFound = null;
            }
            item.InvokeDisInteractEvent();
        }
    }
}

/*
 Interactable interactObj = hit.collider.GetComponent<Interactable>();
                if (interactObj != null)
                {
                    cursorPointImg.color = Color.black;

                    if (currentInteractObj == null)
                    {
                        currentInteractObj = interactObj;
                        currentInteractObj.OnInteract();
                    }
                    else
                    {
                        if (currentInteractObj.gameObject != interactObj.gameObject)
                        {
                            currentInteractObj.OnRelease();
                            currentInteractObj = interactObj;
                            currentInteractObj.OnInteract();
                        }
                        else
                        {

                        }
                    }
                }
                else
                {
                    cursorPointImg.color = Color.white;
                    if (currentInteractObj)
                    {
                        currentInteractObj.OnRelease();
                    }
                    currentInteractObj = null;
                }
 */