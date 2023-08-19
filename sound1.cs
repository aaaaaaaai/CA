using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class sound1 : MonoBehaviour
{
    public AudioClip se1;

    AudioSource audioSource;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Se1()
    {
        audioSource.PlayOneShot(se1);
    }


}

