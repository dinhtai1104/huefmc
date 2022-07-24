using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Checkpoint : MonoBehaviour
{
    private bool isFinishedCheckPoint = false;
    public UnityEvent action;
    public void ShowCheckPoint()
    {
        gameObject.SetActive(true);
    }

    public void CheckpointInvokeAction()
    {
        gameObject.SetActive(false);
        action?.Invoke();
    }
}
