using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragmentDieuTriKhongThuoc : Fragment
{
    public DieuTriKhongThuocRow dieuTriKhongThuocPrefab;
    public RectTransform contentRow;
    private List<DieuTriKhongThuocRow> dieuTriKhongThuocRows = new List<DieuTriKhongThuocRow>();
    private bool isLoaded = false;
    private DieuTriKhongThuocSO dieuTriKhongThuocSO;

    public override void OnEnable()
    {
        base.OnEnable();
        if (!isLoaded) 
        {
            isLoaded = true;
            dieuTriKhongThuocSO = DataManager.Instance.DieuTriKhongThuocSO;
            for (int i = 0; i < dieuTriKhongThuocSO.listDieuTriKhongThuocData.Count; i++)
            {
                DieuTriKhongThuocRow row = Instantiate(dieuTriKhongThuocPrefab, contentRow);
                row.Load(dieuTriKhongThuocSO.listDieuTriKhongThuocData[i]);
                dieuTriKhongThuocRows.Add(row);
            }
        }
    }
    public override void OnLoad()
    {
    }

    public void TuVanOnClicked()
    {
        for (int i = 0; i < dieuTriKhongThuocRows.Count; i++)
        {
            bool isCorrect = dieuTriKhongThuocRows[i].IsTickCorrect();
            if (!isCorrect)
            {
                // Sai - Bao Do
                dieuTriKhongThuocRows[i].InCorrect();
            }
        }
    }
}
