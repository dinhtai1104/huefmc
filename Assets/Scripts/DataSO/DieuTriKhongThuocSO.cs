using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DieuTriKhongThuocSO : ScriptableObject
{
    public List<DieuTriKhongThuocData> listDieuTriKhongThuocData;
}

[System.Serializable]
public class DieuTriKhongThuocData
{
    public string tenDieuTri;
    public bool isValid;
    [TextArea(1, 10)]
    public string errorIfExist;
}