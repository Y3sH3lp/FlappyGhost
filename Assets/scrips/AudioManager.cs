using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("----------- Audio Source -----------")]
    [SerializeField] AudioSource _musicSource;
    [SerializeField] AudioSource _SFXSource;

    [Header("----------- Audio Clip -----------")]
    public AudioClip background;
    public AudioClip wings;
    public AudioClip die;
    public AudioClip point;
    
    private void Start()
    {
        _musicSource.clip=background;
        _musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        _SFXSource.PlayOneShot(clip);
    }


}
