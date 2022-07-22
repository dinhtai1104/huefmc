using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TickChonOption : MonoBehaviour
{
    public Image mainImage;
    public TextMeshProUGUI testName;
    public GameObject tickCheckbox;
    public Color untickColor, tickColor;
    public bool isCheck = false;
    public Button btn;
    private void Start()
    {
        Init();
    }
    public void Init()
    {
        if (mainImage == null)
            mainImage = GetComponent<Image>();
        if (btn == null)
        {
            btn = GetComponent<Button>();
            btn.onClick.AddListener(CheckBoxOnClicked);
        }
        isCheck = false;
        tickCheckbox.SetActive(isCheck);
        mainImage.color = isCheck ? tickColor : untickColor;
    }
    public void CheckBoxOnClicked()
    {
        this.isCheck = !isCheck;
        tickCheckbox.SetActive(isCheck);
        mainImage.color = isCheck ? tickColor : untickColor;
    }
    public virtual bool IsTickCorrect()
    {
        return true;
    }

    public virtual void InCorrect()
    {
        mainImage.color = Color.Lerp(Color.white, Color.red, 0.6f);
    }
}
