using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum ItemType
{
    OngNgheTim,
    OngNghePhoi,
    DenSoiMat,
    DenSoiTai
}
public class InteractItem : MonoBehaviour
{
    public ItemType itemType;

    public UnityEvent interactEvent;
    public UnityEvent disInteractEvent;
    private Grabblable grabble;
    public bool isFinished = false;
    private void OnValidate()
    {
        grabble = GetComponent<Grabblable>();
    }

    public Grabblable GetGrabble() => grabble;
    public void InvokeInteractEvent()
    {
        interactEvent?.Invoke();
        if (itemType == ItemType.OngNgheTim)
        {
            SoundManager.Instance.NgheTim(true);
        }
        else if (itemType == ItemType.OngNghePhoi)
        {
            SoundManager.Instance.NghePhoi(true);
        }
    }

    public void InvokeDisInteractEvent()
    {
        disInteractEvent?.Invoke();
        if (itemType == ItemType.OngNgheTim)
        {
            SoundManager.Instance.NgheTim(false);
        } 
        else if (itemType== ItemType.OngNghePhoi)
        {
            SoundManager.Instance.NghePhoi(false);
        }
    }
}
