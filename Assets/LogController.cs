using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogController : Singleton<LogController>
{
    public List<LogData> logsList = new List<LogData>();

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void Log(LogData logData)
    {
        logsList.Add(logData);
    }
}
