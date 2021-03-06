﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotatocaseController : MonoBehaviour
{
    public AudioClip potatoSE;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {

        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.PlayOneShot(potatoSE);
    }

    // Update is called once per frame
    void Update()
    {
        transform.SetAsLastSibling();
    }
}
