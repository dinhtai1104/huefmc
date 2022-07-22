using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LichSuKhamBenhRow : MonoBehaviour
{
    public Image backgroundImage;
    public TextMeshProUGUI ngayText,
        noiDungText,
        huyetApText,
        nhipTimText,
        nhietDoText,
        nhipThoText,
        canNangText,
        BMIText;
    private ResizeRectByChild[] resizeRects;

    public void LoadData(LichSuKhamBenhData historyExam, bool isColor)
    {
        if (resizeRects == null)
        {
            resizeRects = GetComponentsInChildren<ResizeRectByChild>();
        }
        // Load data
        this.ngayText.text = historyExam.ngayText;
        this.noiDungText.text = historyExam.noiDungText;
        this.huyetApText.text = historyExam.huyetApText;
        this.nhipTimText.text = historyExam.nhipTimText;
        this.nhietDoText.text = historyExam.nhietDoText;
        this.nhipThoText.text = historyExam.nhipThoText;
        this.canNangText.text = historyExam.canNangText;
        this.BMIText.text = historyExam.BMIText;

        backgroundImage.color = isColor ? UiManager.Instance.rowHighLight : UiManager.Instance.rowNormal;

        LayoutRebuilder.ForceRebuildLayoutImmediate(noiDungText.rectTransform);
        for (int i = 0; i < resizeRects.Length; i++)
        {
            resizeRects[i].InvokeResize();
        }
    }
}

