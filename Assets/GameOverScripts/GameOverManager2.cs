using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager2 : MonoBehaviour
{
    public AudioClip sound;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = sound;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToTitle()
    {
        SceneManager.LoadScene("Title");
    }

    public void ToMain()
    {
        SceneManager.LoadScene("Main2");
    }
}

