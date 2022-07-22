using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ChuanDoanSO : ScriptableObject
{
    public List<ChuanDoanData> listChuanDoan;
}

[System.Serializable]
public class ChuanDoanData 
{
    public string tenChuanDoan;
    public bool isValid;
    [TextArea(1, 10)]
    public string errorIfExist;
}
