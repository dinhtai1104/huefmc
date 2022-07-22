using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KetQuaXetNghiemRow : MonoBehaviour
{
    public TextMeshProUGUI
        tenXetNghiem,
        giaTri,
        donVi,
        phamVi;

    private Image backgroundImg;

    public void Load(KetQuaXetNghiemData data, bool isColor)
    {
        if (!backgroundImg)
        {
            backgroundImg = GetComponent<Image>();
        }        
        this.tenXetNghiem.text = data.tenXetNghiem;
        this.giaTri.text = data.giaTri;
        this.donVi.text = data.donVi;
        this.phamVi.text = data.phamVi;

        backgroundImg.color = isColor ? UiManager.Instance.rowHighLight : UiManager.Instance.rowNormal;
    }
}

[System.Serializable]
public class KetQuaXetNghiemData
{
    public string
        tenXetNghiem,
        giaTri,
        donVi,
        phamVi;
}