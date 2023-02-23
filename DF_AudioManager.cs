using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DeaddFinally
{
    public class DF_AudioManager : MonoBehaviour
    {
        [Tooltip("MAIN source of audio.")]
        public AudioSource A_source;

        public void PlayAudioAtLocation(AudioClip ClipToPlay, float pitch, float volume, Vector3 location)
        {
            GameObject SoundOBJ = new GameObject("Sound Object");
            SoundOBJ.AddComponent<AudioSource>();
            AudioSource ASource2 = SoundOBJ.GetComponent<AudioSource>();
            SoundOBJ.transform.position = location;
            ASource2.clip = ClipToPlay;
            ASource2.pitch = pitch;
            ASource2.volume = volume;
            Destroy(SoundOBJ, ASource2.clip.length);
        }
    
        public void PlayAudio(AudioClip ClipToPlay, float pitch, float volume, bool loop)
        {
            A_source.pitch = pitch;
            A_source.volume = volume;
            A_source.loop = loop;
            A_source.clip = ClipToPlay;
            A_source.Play();
        }

        public void PlayAudioOnce(AudioClip ClipToPlay, float pitch, float volume)
        {
            A_source.pitch = pitch;
            A_source.volume = volume;
            A_source.PlayOneShot(ClipToPlay);
        }

        public void StopAllAudios()
        {
            A_source.Stop();
        }
    }

}