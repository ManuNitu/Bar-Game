using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource music;
    public static AudioManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
            Destroy(this.gameObject);
        music = GetComponentInChildren<AudioSource>();
    }
    public void PauseMusic()
    { 
        music.Pause();
    }
    public void ResumeMusic()
    {
        music.Play();
    }
}
