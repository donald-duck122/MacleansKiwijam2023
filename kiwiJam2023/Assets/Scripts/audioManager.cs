using UnityEngine.Audio;
using System;
using UnityEngine;

public class audioManager : MonoBehaviour
{

    [SerializeField] Sound[] sounds;


    void awake(){
        foreach (Sound s in sounds){
            s.source = GameComponent.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    public void play(string soundName){
        Sound s = Array.Find(sounds, sound=> sound.name == soundName)
        s.source.play();
    }
}
