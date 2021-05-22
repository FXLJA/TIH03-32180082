using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_script : MonoBehaviour
{
    private AudioSource sound;
    private void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    public void ToggleSound()
    {
        if (sound.isPlaying)
        {
            sound.Stop();
        }
            else
            {
                sound.Play();
            }
    }
}
