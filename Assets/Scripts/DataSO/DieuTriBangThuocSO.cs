using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DieuTriBangThuocSO : ScriptableObject
{
    public List<DieuTriBangThuocData> listDieuTriBangThuoc;
}

[System.Serializable]
public class DieuTriBangThuocData
{
    public ThuocDataSO thuoc;
    public int lieuLuongMin;
    public int lieuLuongMax;
    public bool isValid;

    [TextArea(1, 10)]
    public string errorIfExist;
}