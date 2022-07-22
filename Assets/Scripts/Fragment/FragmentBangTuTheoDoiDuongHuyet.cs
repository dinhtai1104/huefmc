using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragmentBangTuTheoDoiDuongHuyet : Fragment
{
    public BangTheoDoiDuongHuyetRow rowTheoDoiDuongHuyetPrefab;
    public RectTransform contentRow;
    private BangTheoDoiDuongHuyetSO bangTheoDoiDuongHuyetSO;

    private List<BangTheoDoiDuongHuyetRow> bangTheoDoiDuongHuyetRows = new List<BangTheoDoiDuongHuyetRow>();
    private bool isLoaded = false;
    public override void OnEnable()
    {
        if (!isLoaded)
        {
            isLoaded = true;
            bangTheoDoiDuongHuyetSO = DataManager.Instance.BangTheoDoiDuongHuyetSO;
            LoadData();
        }
    }

    private void LoadData() 
    { 
        for (int i = 0; i < bangTheoDoiDuongHuyetSO.listBangTheoDoiDuongHuyet.Count; i++)
        {
            BangTheoDoiDuongHuyetRow row = Instantiate(rowTheoDoiDuongHuyetPrefab, contentRow);
            row.LoadData(bangTheoDoiDuongHuyetSO.listBangTheoDoiDuongHuyet[i], i % 2 == 1);
            bangTheoDoiDuongHuyetRows.Add(row);
        }
    }


    public override void OnLoad()
    {
    }
}
