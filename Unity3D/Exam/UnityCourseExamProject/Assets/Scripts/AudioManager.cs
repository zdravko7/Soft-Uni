﻿using UnityEngine;
using System.Collections;

public static class AudioManager 
{
    private static AudioClip[] audioClips;

    public static void InitAudioManager()
    {
        audioClips = new AudioClip[1];
        audioClips[0] = (AudioClip)Resources.Load("Sounds/collectCoin");
    }

    public static void PlayAudioSound(AudioSounds sound, bool isUsingNewGameObject)
    {
        AudioClip clipToPlay = audioClips[(int)sound];

        if (clipToPlay == null)
        {
            return;
        }

        if (isUsingNewGameObject)
        {
            AudioSource.PlayClipAtPoint(clipToPlay, Camera.main.transform.position);
        }
        else
        {
            Camera.main.GetComponent<AudioSource>().PlayOneShot(clipToPlay);
        }
    }
}

public enum AudioSounds
{
    CollectCoin = 0
}
