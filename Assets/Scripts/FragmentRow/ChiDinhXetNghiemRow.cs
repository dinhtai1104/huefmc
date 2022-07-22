using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ChiDinhXetNghiemRow : TickChonOption
{
    private ChiDinhXetNghiemData chiDinhXetNghiemData;
    

    public bool IsCheckBox() => isCheck;

    public void Load(ChiDinhXetNghiemData chiDinhXetNghiemData)
    {
        this.chiDinhXetNghiemData = chiDinhXetNghiemData;
        this.testName.text = chiDinhXetNghiemData.tenChiDinh;
    }

    public override bool IsTickCorrect()
    {
        return isCheck && chiDinhXetNghiemData.isValid;
    }
    public string GetNameItem() => testName.text;

    public void Load(string nameTest)
    {
        base.Init();
        this.testName.text = nameTest;
    }

    
}
