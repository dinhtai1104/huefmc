using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public abstract class Fragment : MonoBehaviour
{
    public RectTransform container;
    public virtual void Init()
    {

    }
    public virtual void OnEnable()
    {

    }

    private void OnValidate()
    {
        container = transform.GetChild(0) as RectTransform;
    }

    public void OnShow()
    {
        OnLoad();
        gameObject.SetActive(true);
        container.DOScale(Vector3.one, 0.25f).From(Vector3.zero);
    }

    public abstract void OnLoad();

    public void OnClose()
    {
        container.DOScale(Vector3.zero, 0.25f).OnComplete(() =>
        {
            gameObject.SetActive(false);
        });
    }
}
