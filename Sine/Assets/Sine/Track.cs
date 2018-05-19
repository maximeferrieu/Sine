using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

namespace Sine
{
    [Serializable]
    public class Track
    {
        public string name;

        public PlaybackBehavior behavior;

        public AudioMixerGroup output;

        public Range initialDelayRange = new Range(0f, 0f);

        public Range volumeRange = new Range(0f,1f);

        public Range pitchRange = new Range(0.01f, 3f);

        public List<AudioClip> clips = new List<AudioClip>();
    }
}

