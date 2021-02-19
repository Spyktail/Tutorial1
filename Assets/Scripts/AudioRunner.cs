using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioRunner : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioClip musicClip;
    public AudioClip soundEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            musicSource.clip = musicClip;
            musicSource.Play();
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            musicSource.Stop();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            musicSource.clip = soundEffect;
            musicSource.Play();
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            musicSource.Stop();
        }
        if (Input.GetKeyDown(KeyCode.L))

        {

          musicSource.loop = true;

         }

     if (Input.GetKeyUp(KeyCode.L))

        {

          musicSource.loop = false;

        }
    }
}
