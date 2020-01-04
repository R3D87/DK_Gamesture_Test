using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundPlayer : MonoBehaviour
{
    [SerializeField]
    private AudioClip _sound;
    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();

        if (_audioSource == null)
        {
            _audioSource = gameObject.AddComponent<AudioSource>();
        }
        _audioSource.clip = _sound;
        _audioSource.playOnAwake = false;
    }

    public void PlaySound()
    {
        if (_sound == null)
            return;

        if (_audioSource.isPlaying)
            return;

        _audioSource.Play();
    }
}
