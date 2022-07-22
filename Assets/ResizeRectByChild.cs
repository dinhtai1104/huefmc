using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AxisSet
{
    HORIZONTAL,
    VERTICAL,
    BOTH
}
public class ResizeRectByChild : MonoBehaviour
{
    public RectTransform childRectTransform;
    public RectTransform parentRectTransform;
    public AxisSet axis = AxisSet.VERTICAL;
    private void OnValidate()
    {
        RebuildRectTransform();
    }

    private void RebuildRectTransform()
    {
        if (parentRectTransform == null || childRectTransform == null)
        {
            return;
        }
        if (axis == AxisSet.VERTICAL)
        {
            Rect parentRect = parentRectTransform.rect;
            Rect childRect = childRectTransform.rect;
            float heightPrefer = childRect.height;
            parentRectTransform.sizeDelta
                = new Vector2(parentRectTransform.sizeDelta.x, heightPrefer);
        }
        else if (axis == AxisSet.HORIZONTAL)
        {
            Rect parentRect = parentRectTransform.rect;
            Rect childRect = childRectTransform.rect;
            float widthPrefer = childRect.width;
            parentRectTransform.sizeDelta
                = new Vector2(widthPrefer, parentRectTransform.sizeDelta.y);
        }
        else
        {
            Rect parentRect = parentRectTransform.rect;
            Rect childRect = childRectTransform.rect;
            float widthPrefer = childRect.width;
            float heightPrefer = childRect.height;
            parentRectTransform.sizeDelta
                = new Vector2(widthPrefer, heightPrefer);
        }
    }

    private float GetMax(float a, float b)
    {
        if (a > b) return a;
        return b;
    }

    private void OnEnable()
    {
        RebuildRectTransform();
    }

    public void InvokeResize()
    {
        RebuildRectTransform();
    }

    private void Update()
    {
        RebuildRectTransform();
    }
}
