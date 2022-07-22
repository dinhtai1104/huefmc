using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RowLogItem : MonoBehaviour
{
    public TextMeshProUGUI
        ngayText,
        hanhDongText,
        thoiGianThucHienText;

    public Image backgroundImg;
    private void OnValidate()
    {
        backgroundImg = GetComponent<Image>();
    }
    public void LoadData(LogData log, bool isColor)
    {
        this.ngayText.text = log.ngay;
        this.hanhDongText.text = log.hanhDong;
        this.thoiGianThucHienText.text = log.thoiGianThucHien;
        backgroundImg.color = isColor ? UiManager.Instance.rowHighLight : UiManager.Instance.rowNormal;
    }
}

public class LogData
{
    public string ngay { set; get; }
    public string hanhDong { set; get; }
    public string thoiGianThucHien { get; set; }
}