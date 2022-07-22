using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BangTheoDoiDuongHuyetRow : MonoBehaviour
{
    public Image backgroundImage;
    public TextMeshProUGUI ngayText,
        truocBuaSangText,
        truocBuaTruaText,
        truocBuaToiText,
        ghiChuText;

    private ResizeRectByChild[] resizeRects;

    public void LoadData(BangTheoDoiDuongHuyetTaiNhaData bloodSugar, bool isColor)
    {
        if (resizeRects == null)
        {
            resizeRects = GetComponentsInChildren<ResizeRectByChild>();
        }
        // Load data
        this.ngayText.text = bloodSugar.ngayText;
        this.truocBuaSangText.text = bloodSugar.truocBuaSangText;
        this.truocBuaTruaText.text = bloodSugar.truocBuaTruaText;
        this.truocBuaToiText.text = bloodSugar.truocBuaToiText;
        this.ghiChuText.text = bloodSugar.ghiChuText;

        backgroundImage.color = isColor ? UiManager.Instance.rowHighLight : UiManager.Instance.rowNormal;

        LayoutRebuilder.ForceRebuildLayoutImmediate(ghiChuText.rectTransform);
        for (int i = 0; i < resizeRects.Length; i++)
        {
            resizeRects[i].InvokeResize();
        }
    }
}

