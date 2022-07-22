using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FragmentLog : Fragment
{
    public RowLogItem rowPrefab;
    public RectTransform contentRow;
    private List<RowLogItem> listLogs = new List<RowLogItem>();
    public override void OnEnable()
    {
        List<LogData> log = LogController.Instance.logsList;
        foreach (RowLogItem r in listLogs)
        {
            Destroy(r.gameObject);
        }
        listLogs.Clear();
        for (int i = 0; i < log.Count; i++)
        {
            RowLogItem row = Instantiate(rowPrefab, contentRow);
            row.LoadData(log[i], i % 2 == 1);
            listLogs.Add(row);
        }
    }
    public override void OnLoad()
    {
    }
}
