using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    private AudioSource audioSource;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        float randPitch = Random.Range(0.8f, 1f);
        audioSource.pitch = randPitch;
    }
    private void Update()
    {
        if (!audioSource.isPlaying)
            Destroy(this.gameObject);
    }
}
