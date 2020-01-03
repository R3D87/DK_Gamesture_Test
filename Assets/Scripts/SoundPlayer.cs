using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundPlayer : MonoBehaviour
{
    [SerializeField]
    private AudioClip sound;
    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();

        if (_audioSource == null)
        {
            _audioSource = gameObject.AddComponent<AudioSource>();
        }
        _audioSource.clip = sound;
        _audioSource.playOnAwake = false;
    }

    public void PlaySound()
    {
        if (sound == null)
            return;

        if (_audioSource.isPlaying)
            return;

        _audioSource.Play();
    }
}
