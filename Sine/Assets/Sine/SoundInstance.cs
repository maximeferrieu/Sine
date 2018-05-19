using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Sine
{
    public class SoundInstance : MonoBehaviour
    {
        private bool hasPlayed = false;

        private AudioSource source;

        /// <summary>
        /// Factory method to create a Sound Instance
        /// </summary>
        /// <param name="clip"></param>
        /// <param name="loop"></param>
        /// <returns></returns>
        public SoundInstance CreateNew (AudioClip clip, bool loop)
        {
            // Creates a new AudioSource on the gameObject
            source = gameObject.AddComponent<AudioSource>();

            // Setup default values of source
            source.playOnAwake = false;
            
            // Setup passed values of source
            source.clip = clip;
            source.loop = loop;

            // Play source and starts the Check for Destroy logic
            source.Play();
            hasPlayed = true;
            StartCoroutine(CheckForDestroy());

            return this;
        }

        /// <summary>
        /// The broadcast event triggered when the instance has finished to play
        /// </summary>
        public event Action<SoundInstance> OnSoundInstanceFinished;

        /// <summary>
        /// This is meant to be called when the sound instance has finished to Play
        /// </summary>
        private void Destroy()
        {
            // Fires OnSoundInstanceFinished event passing the self reference
            if (OnSoundInstanceFinished != null)
            {
                OnSoundInstanceFinished(this); 
            }

            // Destroys the gameObject
            Destroy(gameObject);
            return;
        }

        /// <summary>
        /// Waits for source to finish to play & triggers the Destroy() method
        /// </summary>
        /// <returns></returns>
        private IEnumerator CheckForDestroy()
        {
            while (hasPlayed && source.isPlaying)
            {
                yield return null;
            }
            Destroy();
        }
    }
}
