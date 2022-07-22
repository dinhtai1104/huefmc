using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieuTriKhongThuocRow : TickChonOption
{
    private DieuTriKhongThuocData dieuTriKhongThuoc;
    public void Load(DieuTriKhongThuocData dieuTriKhongThuocData)
    {
        this.dieuTriKhongThuoc = dieuTriKhongThuocData;
        this.testName.text = dieuTriKhongThuoc.tenDieuTri;
    }

    public override bool IsTickCorrect()
    {
        return isCheck && dieuTriKhongThuoc.isValid;
    }
}
