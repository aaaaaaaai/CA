using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class sound : MonoBehaviour
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
        Debug.Log("click se1");
    }


}
