using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AidensWork;

namespace AidensWork
{
    /// <summary>
    /// Author: Aiden Cran
    /// Date:
    /// Last Edited:
    /// 
    /// 
    /// </summary>
    public class GameAudio : MonoBehaviour
    {
        public static GameAudio instance;

        private AudioSource _audioSource;

        public AudioClip[] Clips;

        private void Awake()
        {
            if (instance == null)
                instance = this;
            else
                Destroy(gameObject);

            DontDestroyOnLoad(transform.gameObject);
            _audioSource = GetComponent<AudioSource>();
        }

        public void PlayMusic()
        {
            if (_audioSource.isPlaying) return;
            _audioSource.Play();
        }

        public void StopMusic()
        {
            _audioSource.Stop();
        }

        public void PlayMenuMusic()
        {
            _audioSource.clip = Clips[0];
            PlayMusic();
        }

        public void PlayBattleMusic()
        {
            _audioSource.clip = Clips[1];
            PlayMusic();
        }

        private void Start()
        {
            PlayMusic();
        }
    }
}
