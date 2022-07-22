using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChuanDoanRow : TickChonOption
{
    private ChuanDoanData chuanDoanData;
    public void Load(ChuanDoanData chuanDoanData)
    {
        this.chuanDoanData = chuanDoanData;
        this.testName.text = this.chuanDoanData.tenChuanDoan;
    }
    public override bool IsTickCorrect()
    {
        return isCheck && chuanDoanData.isValid;
    }
}
