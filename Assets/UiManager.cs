using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : Singleton<UiManager>
{
    public FragmentThongTinBenhNhan fragmentThongTinBenhNhan;
    public FragmentBangTuTheoDoiDuongHuyet fragmentBangTuTheoDoiDuong;
    public FragmentChiDinhXetNghiem fragmentChiDinhXetNghiem;
    public FragmentChuanDoan fragmentChuanDoan;
    public FragmentDieuTriKhongThuoc fragmentDieuTriKhongThuoc;
    public FragmentLichSuKhamBenh fragmentLichSuKhamBenh;
    public FragmentLichSuXetNghiem fragmentLichSuXetNghiem;

    public FragmentMessage fragmentMessage;

    public Color rowHighLight, rowNormal;

    private void OnValidate()
    {
        if (fragmentThongTinBenhNhan == null)
        {
            fragmentThongTinBenhNhan = FindObjectOfType<FragmentThongTinBenhNhan>();
            fragmentBangTuTheoDoiDuong = FindObjectOfType<FragmentBangTuTheoDoiDuongHuyet>();
            fragmentChiDinhXetNghiem = FindObjectOfType<FragmentChiDinhXetNghiem>();
            fragmentChuanDoan = FindObjectOfType<FragmentChuanDoan>();
            fragmentDieuTriKhongThuoc = FindObjectOfType<FragmentDieuTriKhongThuoc>();
            fragmentLichSuKhamBenh = FindObjectOfType<FragmentLichSuKhamBenh>();
            fragmentLichSuXetNghiem = FindObjectOfType<FragmentLichSuXetNghiem>();
        }
    }

    private void Start()
    {
        ShowFragment(fragmentThongTinBenhNhan);
    }


    public void ShowMessage(string title, string content)
    {
        fragmentMessage.OnShow(title, content);
    }
    public void ShowFragment(Fragment fragment)
    {
        fragment.OnShow();
    }
}
