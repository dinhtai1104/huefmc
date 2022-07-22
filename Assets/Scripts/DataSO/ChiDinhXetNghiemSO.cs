using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ChiDinhXetNghiemSO : ScriptableObject
{
    public List<ChiDinhXetNghiemData> listChiDinhXetNghiem;
}

[System.Serializable]
public class ChiDinhXetNghiemData
{
    public string tenChiDinh;
    public bool isValid;
    [TextArea(1, 10)]
    public string errorIfExist;
}