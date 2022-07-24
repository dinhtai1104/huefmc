using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCheckPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Checkpoint"))
        {
            Checkpoint checkpoint = other.GetComponent<Checkpoint>();
            checkpoint.CheckpointInvokeAction();
        }
    }
}
