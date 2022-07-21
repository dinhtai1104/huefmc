using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MedicalTestItem : MonoBehaviour
{
    private Image mainImage;
    public TextMeshProUGUI testName;
    public GameObject tickCheckbox;
    public Color untickColor, tickColor;
    private bool isCheck = false;
    private Button btn;

    private void Start()
    {
        Init();  
    }
    private void Init()
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

    public bool IsCheckBox() => isCheck;
    public string GetNameItem() => testName.text;

    public void Load(string nameTest)
    {
        Init();
        this.testName.text = nameTest;
    }

    public void CheckBoxOnClicked()
    {
        this.isCheck = !isCheck;
        tickCheckbox.SetActive(isCheck);
        mainImage.color = isCheck ? tickColor : untickColor;
    }
}
