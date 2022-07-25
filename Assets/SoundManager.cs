using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class SoundManager : Singleton<SoundManager>
{
    public AudioSource thongTinBenhNhanADS;
    public AudioSource sfx;
    public AudioSource NgheTimADS;
    public AudioSource NghePhoiADS;

    [Header("Button")]
    public AudioClip highLightBtn;
    public AudioClip pressedBtn;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }


    public void PlaySFX(AudioClip a)
    {
        sfx.PlayOneShot(a);
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

    public void NgheTim(bool v)
    {
        if (v)
            NgheTimADS.Play();
        else
            NgheTimADS.Stop();
    }

    public void NghePhoi(bool v)
    {
        if (v)
            NghePhoiADS.Play();
        else
            NghePhoiADS.Stop();
    }

    public void StopLongAudioSource(AudioSource a)
    {
        a.DOFade(0, 0.5f).OnComplete(() =>
        {
            a.Stop();
        });
    }
}
