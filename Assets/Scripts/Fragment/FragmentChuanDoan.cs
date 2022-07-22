using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragmentChuanDoan : Fragment
{
    public ChuanDoanRow chuanDoanRowPrefab;
    private ChuanDoanSO chuanDoanSO;
    public RectTransform contentRow;
    private List<ChuanDoanRow> chuanDoanRows = new List<ChuanDoanRow>();
    private bool isLoaded = false;

    public override void OnEnable()
    {
        base.OnEnable();
        if (!isLoaded)
        {
            isLoaded = true;
            chuanDoanSO = DataManager.Instance.ChuanDoanSO;
            for (int i = 0; i < chuanDoanSO.listChuanDoan.Count; i++)
            {
                ChuanDoanRow row = Instantiate(chuanDoanRowPrefab, contentRow);
                row.Load(chuanDoanSO.listChuanDoan[i]);
                chuanDoanRows.Add(row);
            }
        }
    }
    public override void OnLoad()
    {
    }

    public void ChuanDoanOnClicked()
    {
        for (int i = 0; i < chuanDoanRows.Count; i++)
        {
            bool isCorrect = chuanDoanRows[i].IsTickCorrect();
            if (!isCorrect)
            {
                // Sai - Bao Do
                chuanDoanRows[i].InCorrect();
            }
        }
    }
}
