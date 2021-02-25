using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject comment1;
    public GameObject comment2;
    public GameObject comment3;
    public GameObject comment4;

    public AudioClip soundSE;
    private AudioSource audioSourceSE;

    // Start is called before the first frame update
    void Start()
    {
        audioSourceSE = gameObject.GetComponent<AudioSource>();
        audioSourceSE.clip = soundSE;

        Invoke("AppearComment1", 2);
        Invoke("AppearComment2", 3);
        Invoke("AppearComment3", 4);
        Invoke("AppearComment4", 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //開始時の一連の処理
    void AppearComment1()
    {
        audioSourceSE.Play();
        comment1.SetActive(true);
    }

    void AppearComment2()
    {
        audioSourceSE.Play();
        comment2.SetActive(true);
    }

    void AppearComment3()
    {
        audioSourceSE.Play();
        comment3.SetActive(true);
    }

    void AppearComment4()
    {
        audioSourceSE.Play();
        comment4.SetActive(true);
    }
}
