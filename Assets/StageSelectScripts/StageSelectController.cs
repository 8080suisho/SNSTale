using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelectController : MonoBehaviour
{

    public AudioClip menueBGM;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();

        BGMPlay();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToTutorial()
    {  
        SceneManager.LoadScene("Tutorial");
    }

    public void ToTomomi()
    {
        SceneManager.LoadScene("Main");
    }

    public void ToTencho()
    {
        SceneManager.LoadScene("Main2");
    }

    void BGMPlay()
    {
        audioSource.PlayOneShot(menueBGM);
    }
}
