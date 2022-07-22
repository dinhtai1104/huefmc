using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FragmentLichSuKhamBenh : Fragment
{
    public LichSuKhamBenhRow lichSuKhamBenhPrefab;
    public RectTransform contentRow;
    public TextMeshProUGUI TienSuText;
    private List<LichSuKhamBenhRow> listLichSuKhamBenh = new List<LichSuKhamBenhRow>();
    private LichSuKhamBenhSO lichSuKhamBenhSO;
    private bool isLoaded = false;
    public override void OnEnable()
    {
        base.OnEnable();
        if (!isLoaded)
        {
            lichSuKhamBenhSO = DataManager.Instance.LichSuKhamBenhSO;
            isLoaded = true;
            TienSuText.text = lichSuKhamBenhSO.TienSu;
            for (int i = 0; i < lichSuKhamBenhSO.listLichSuKhamBenh.Count; i++)
            {
                LichSuKhamBenhRow row = Instantiate(lichSuKhamBenhPrefab, contentRow);
                row.LoadData(lichSuKhamBenhSO.listLichSuKhamBenh[i], i % 2 == 1);
                listLichSuKhamBenh.Add(row);
            }
        }
    }
    public override void OnLoad()
    {
    }
}
