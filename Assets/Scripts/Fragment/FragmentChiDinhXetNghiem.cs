using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragmentChiDinhXetNghiem : Fragment
{
    public ChiDinhXetNghiemRow chiDinhXetNghienPrefab;
    private ChiDinhXetNghiemSO chiDinhXetNghiemSO;
    public RectTransform contentRow;

    private List<ChiDinhXetNghiemRow> chiDinhXetNghiemRows = new List<ChiDinhXetNghiemRow>();
    private bool isLoaded = false;
    public override void OnEnable()
    {
        base.OnEnable();
        if (!isLoaded)
        {
            isLoaded = true;
            chiDinhXetNghiemSO = DataManager.Instance.ChiDinhXetNghiemSO;
            for (int i = 0; i < chiDinhXetNghiemSO.listChiDinhXetNghiem.Count; i++)
            {
                ChiDinhXetNghiemRow row = Instantiate(chiDinhXetNghienPrefab, contentRow);
                chiDinhXetNghiemRows.Add(row);
                row.Load(chiDinhXetNghiemSO.listChiDinhXetNghiem[i]);
            }
        }
    }
    public override void OnLoad()
    {
    }

    public void ChiDinhXetNghiemOnClicked()
    {
        for (int i = 0; i < chiDinhXetNghiemRows.Count; i++)
        {
            bool isCorrect = chiDinhXetNghiemRows[i].IsTickCorrect();
            if (!isCorrect)
            {
                // Sai - Bao Do
                chiDinhXetNghiemRows[i].InCorrect();
            }
        }
    }
}
