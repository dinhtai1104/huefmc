using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ThuocDataSO : ScriptableObject
{
    public Sprite thuocSprite;
    public string tenThuocDisplay;
    public string tenThuocDayDu;
    [TextArea(1, 10)]
    public string chiDinh;

    [TextArea(1, 10)]
    public string errorIfExist;
}
