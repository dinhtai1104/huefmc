using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Grabblable : MonoBehaviour
{
    private Rigidbody myRb;
    private Vector3 startPos;
    private Quaternion startQuaternion;
    private Transform _transform;
    public bool isGrabbled = false;

    public Checkpoint checkPoint;

    private void Start()
    {
        myRb = GetComponent<Rigidbody>();
        _transform = transform;
        startPos = transform.position;
        startQuaternion = transform.rotation;
        myRb.isKinematic = true;
    }
    public void OnGrabble(Transform hand)
    {
        if (checkPoint)
            checkPoint.ShowCheckPoint();
        isGrabbled = true;
        myRb.isKinematic = true;
        myRb.velocity = Vector3.zero;
        myRb.angularVelocity = Vector3.zero;

        _transform.SetParent(hand);
        _transform.DOLocalMove(Vector3.zero, 0.3f);
        _transform.DORotateQuaternion(hand.rotation, 0.2f);
        _transform.localScale = Vector3.one;

    }

    public void OnRelease()
    {
        isGrabbled = false;
        _transform.SetParent(null);
        myRb.isKinematic = false;
        _transform.localScale = Vector3.one;
    }
}
