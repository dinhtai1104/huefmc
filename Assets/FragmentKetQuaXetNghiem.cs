using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragmentKetQuaXetNghiem : Fragment
{
    public KetQuaXetNghiemRow ketQuaXetNghiemRowPrefab;
    private List<KetQuaXetNghiemRow> ketQuaXetNghiemRows = new List<KetQuaXetNghiemRow>();
    private bool isLoaded = false;
    public RectTransform contentRow;
    private KetQuaXetNghiemSO ketQuaXetNghiemSO;

    public override void OnEnable()
    {
        base.OnEnable();
        if (!isLoaded)
        {
            isLoaded = true;
            ketQuaXetNghiemSO = DataManager.Instance.KetQuaXetNghiemSO;
            for (int i = 0; i < ketQuaXetNghiemSO.listKetQuaXetNghiem.Count; i++)
            {
                KetQuaXetNghiemRow row = Instantiate(ketQuaXetNghiemRowPrefab, contentRow);
                row.Load(ketQuaXetNghiemSO.listKetQuaXetNghiem[i], i % 2 == 1);
                ketQuaXetNghiemRows.Add(row);
            }
        }
    }
    public override void OnLoad()
    {
    }
}
