using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FragmentThongTinBenhNhan : Fragment
{
    private Button[] allButtons;
    private bool isShowFirstTime = false;

    public TextMeshProUGUI
        hoVaTenText,
        tuoiText,
        chieuCaoText,
        canNangText,
        BMIText,
        gioiTinhText,
        ngheNghiepText,
        diUngText;
    public TextMeshProUGUI
        thongTinKham,
        tinhTrang;

    private ThongTinBenhNhanSO thongTinBenhNhan = null;
    private void Start()
    {
        Init();
    }
    public override void OnLoad()
    {
        
    }
    public override void Init()
    {
        base.Init();
    }

    public override void OnEnable()
    {
        if (allButtons == null)
        {
            allButtons = GetComponentsInChildren<Button>();
            // First Time
            thongTinBenhNhan = DataManager.Instance.ThongTinBenhNhanSO;
            OnLoadData(thongTinBenhNhan);
        }

        if (!isShowFirstTime)
        {
            SoundManager.Instance.PlayLongAudioSource(SoundManager.Instance.thongTinBenhNhanADS, ()=>
            {
                foreach (Button btn in allButtons)
                {
                    btn.interactable = true;
                }
            });
            foreach (Button btn in allButtons)
            {
                btn.interactable = false;
            }
        } else
        {
            SoundManager.Instance.StopLongAudioSource(SoundManager.Instance.thongTinBenhNhanADS);
            foreach (Button btn in allButtons)
            {
                btn.interactable = true;
            }
        }
        isShowFirstTime = true;
    }

    private void OnLoadData(ThongTinBenhNhanSO data)
    {
        hoVaTenText.text = data.thongTinBenhNhan.hoVaTenText;
        tuoiText.text = data.thongTinBenhNhan.tuoiText;
        chieuCaoText.text = data.thongTinBenhNhan.chieuCaoText;
        canNangText.text = data.thongTinBenhNhan.canNangText;
        BMIText.text = data.thongTinBenhNhan.BMIText;
        gioiTinhText.text = data.thongTinBenhNhan.gioiTinhText;
        ngheNghiepText.text = data.thongTinBenhNhan.ngheNghiepText;
        diUngText.text = data.thongTinBenhNhan.diUngText;
        thongTinKham.text = data.thongTinBenhNhan.thongTinKham;
        tinhTrang.text = data.thongTinBenhNhan.tinhTrang;
}

    public void BatDauKhamOnClicked()
    {

    }

    public void BangTheoDoiDuongHuyetOnClicked()
    {
        gameObject.SetActive(false);
        UiManager.Instance.ShowFragment(UiManager.Instance.fragmentBangTuTheoDoiDuong);
    }

    public void LichSuKhamBenhOnClicked()
    {
        gameObject.SetActive(false);
        UiManager.Instance.ShowFragment(UiManager.Instance.fragmentLichSuKhamBenh);
    }

    public void LichSuXetNghiemOnClicked()
    {
        gameObject.SetActive(false);
        UiManager.Instance.ShowFragment(UiManager.Instance.fragmentLichSuXetNghiem);
    }

    public void CloseOnClicked()
    {
        OnClose();
    }
    
}

[System.Serializable]
public class ThongTinBenhNhanData
{
    public string
        hoVaTenText,
        tuoiText,
        chieuCaoText,
        canNangText,
        BMIText,
        gioiTinhText,
        ngheNghiepText,
        diUngText;

    [TextArea(1, 10)]
    public string
        thongTinKham,
        tinhTrang;
}
