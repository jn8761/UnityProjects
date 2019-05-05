using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public AudioClip winSound;
    public AudioSource musicSource;
    // Update is called once per frame

    void Start()
    {
        musicSource.clip = winSound;
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        musicSource.Play();
    }
}
