using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class RowThuoc : MonoBehaviour
{
    public Image mainImage;
    public TextMeshProUGUI tenThuocText;

    private DieuTriBangThuocData dieuTriBangThuocData;
    private Button btn;
    public Image background;
    public Sprite chooseSpr, unChooseSpr;
    public void LoadData(DieuTriBangThuocData data)
    {
        if (!btn)
        {
            btn = GetComponent<Button>();
            btn.onClick.AddListener(ChooseThisDrug);
        }
        this.dieuTriBangThuocData = data;
        mainImage.sprite = data.thuoc.thuocSprite;
        tenThuocText.text = dieuTriBangThuocData.thuoc.tenThuocDisplay;
    }

    private void ChooseThisDrug()
    {
        this.background.sprite = chooseSpr;
        FragmentDieuTriBangThuoc.Instance.ChooseThuoc(this);
    }

    public DieuTriBangThuocData GetData() => dieuTriBangThuocData;

    public void Refresh()
    {
        this.background.sprite = unChooseSpr;
    }

    public void Choose()
    {
        this.background.sprite = chooseSpr;
    }
}
