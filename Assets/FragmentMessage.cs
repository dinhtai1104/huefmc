using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Action = System.Action;
using UnityEngine.UI;
using TMPro;

public class FragmentMessage : Fragment
{
    public TextMeshProUGUI title;
    public TextMeshProUGUI content;
    public Action callback;

    public void OnShow(string title, string content, Action callback = null)
    {
        base.OnShow();
        this.title.text = title;
        this.content.text = content;
        this.callback = callback;
    }
    public override void OnCallBack()
    {
        base.OnCallBack();
        callback?.Invoke();
    }

    public override void OnLoad()
    {
    }
}
