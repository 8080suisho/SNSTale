using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlertController : MonoBehaviour
{
    public AudioClip alertSE;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.PlayOneShot(alertSE);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
