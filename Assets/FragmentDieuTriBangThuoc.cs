using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FragmentDieuTriBangThuoc : Fragment
{

    public static FragmentDieuTriBangThuoc Instance;
    public RowThuoc rowThuocPrefab;

    public TextMeshProUGUI lieuLuongText;
    public TextMeshProUGUI tenThuocChiTietText;
    public TextMeshProUGUI chiDinhChiTietText;

    public Image mainImageThuoc;
    public RectTransform contentParentThuoc;

    private List<RowThuoc> listRowThuoc = new List<RowThuoc>();
    private RowThuoc currentThuocChoose = null;
    private bool isLoaded = false;
    private int currentLieuLuong = 0;
    private DieuTriBangThuocSO dieuTriBangThuocSO;
    private void Awake()
    {
        Instance = this;
    }
    public override void OnEnable()
    {
        base.OnEnable();
        if (!isLoaded)
        {
            dieuTriBangThuocSO = DataManager.Instance.DieuTriBangThuocSO;
            for (int i = 0; i < dieuTriBangThuocSO.listDieuTriBangThuoc.Count; i++)
            {
                RowThuoc row = Instantiate(rowThuocPrefab, contentParentThuoc);
                row.LoadData(dieuTriBangThuocSO.listDieuTriBangThuoc[i]);
                listRowThuoc.Add(row);
            }
            isLoaded = true;
        }
        for (int i = 0; i < listRowThuoc.Count; i++)
        {
            listRowThuoc[i].Refresh();
        }
        ChooseThuoc(listRowThuoc[0]);
    }

    public void ChooseThuoc(RowThuoc thuoc)
    {
        if (currentThuocChoose != null)
        {
            currentThuocChoose.Refresh();
        }
        currentThuocChoose = thuoc;
        currentThuocChoose.Choose();
        ThuocDataSO thuocData = thuoc.GetData().thuoc;
        mainImageThuoc.sprite = thuocData.thuocSprite;
        tenThuocChiTietText.text = thuocData.tenThuocDayDu;
        chiDinhChiTietText.text = thuocData.chiDinh;
        currentLieuLuong = 0;
        lieuLuongText.text = currentLieuLuong.ToString();
    }


    public void UpLieuLuongOnClicked()
    {
        currentLieuLuong += 10;
        lieuLuongText.text = currentLieuLuong.ToString();
    }

    public void DownLieuLuongOnClicked()
    {
        currentLieuLuong -= 10;
        if (currentLieuLuong < 0) currentLieuLuong = 0;
        lieuLuongText.text = currentLieuLuong.ToString();
    }

    public override void OnLoad()
    {
    }
}
