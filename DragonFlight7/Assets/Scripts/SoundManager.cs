using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    AudioSource myAudio; // 사운드를 재생할 오디오 소스

    public AudioClip soundExplosion; // 재생 될 오디오 에셋
    public AudioClip soundDie;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void SoundDie()
    {
        myAudio.PlayOneShot(soundDie);
    }
    public void SoundExplosion()
    {
        myAudio.PlayOneShot(soundExplosion);
    }
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
    }
}
