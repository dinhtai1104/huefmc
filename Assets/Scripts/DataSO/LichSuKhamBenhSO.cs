using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class LichSuKhamBenhSO : ScriptableObject
{
    [TextArea(1, 10)]
    public string TienSu;
    public List<LichSuKhamBenhData> listLichSuKhamBenh;
}

[System.Serializable]
public class LichSuKhamBenhData
{
    public string ngayText;
    [TextArea(1, 12)]
    public string
        noiDungText;
    public string
        huyetApText,
        nhipTimText,
        nhietDoText,
        nhipThoText,
        canNangText,
        BMIText;
}
