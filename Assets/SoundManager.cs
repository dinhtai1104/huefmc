using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SoundManager : Singleton<SoundManager>
{
    public AudioSource thongTinBenhNhanADS;

    private void Awake()
    {
    }

    public void PlayLongAudioSource(AudioSource a, System.Action callBack = null)
    {
        a.mute = false;
        a.DOFade(1, 0.2f);
        a.PlayDelayed(0.2f);
        if (callBack != null)
        {
            StartCoroutine(StartMethod(a.clip.length, callBack));
        }
    }
    private IEnumerator StartMethod(float clipLength, System.Action callBack)
    {
        yield return new WaitForSeconds(clipLength);

        callBack?.Invoke();

    }
    public void StopLongAudioSource(AudioSource a)
    {
        a.DOFade(0, 0.5f).OnComplete(() =>
        {
            a.Stop();
        });
    }
}
