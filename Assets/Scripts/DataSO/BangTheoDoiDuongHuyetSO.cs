using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BangTheoDoiDuongHuyetSO : ScriptableObject
{
    public List<BangTheoDoiDuongHuyetTaiNhaData> listBangTheoDoiDuongHuyet;
}
[System.Serializable]
public class BangTheoDoiDuongHuyetTaiNhaData
{
    public string ngayText,
        truocBuaSangText,
        truocBuaTruaText,
        truocBuaToiText;
    [TextArea(1, 12)]
    public string
        ghiChuText;
}
