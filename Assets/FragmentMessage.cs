using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FragmentMessage : Fragment
{
    public TextMeshProUGUI title;
    public TextMeshProUGUI content;

    public void OnShow(string title, string content)
    {
        base.OnShow();
        this.title.text = title;
        this.content.text = content;
    }

    public override void OnLoad()
    {
    }
}
