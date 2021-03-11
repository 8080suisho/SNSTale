using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialController : MonoBehaviour
{
    public GameObject tcom1;
    public GameObject tcom2;
    public GameObject tcom3;

    public GameObject tcom4;
    public GameObject tcom5;
    public GameObject tcom6;

    private GameObject tcom4Object;
    private GameObject tcom5Object;
    private GameObject tcom6Object;

    public GameObject tcom7;
    public GameObject tcom8;
    public GameObject tcom9;

    public AudioClip soundSE;

    private AudioSource audioSource;

    bool commentsAppear = false;
    

    float seconds;
    float count;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();


        Invoke("AppearTcom1", 1);
        Invoke("AppearTcom2", 2);
        Invoke("AppearTcom3", 3);

    }

    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime;
        count += Time.deltaTime;

        FirstAttack();

        if (seconds >= 7 && seconds < 8)
        {
            if (count >= 1)
            {
                count = 0;
                AppearTcom4();
            }
        }

        if(seconds >= 8 && seconds < 9)
        {
            if (count >= 1)
            {
                count = 0;
                AppearTcom5();
            }
        }

        if (seconds >= 9 && seconds < 10)
        {
            if (count >= 1)
            {
                count = 0;
                AppearTcom6();
            }
        }

        if (seconds >= 10 && seconds < 11)
        {

            SeccondAttack();

        }

        if (seconds >= 12 && seconds < 13)
        {
            if (count >= 1)
            {
                count = 0;
                AppearTcom7();
            }

        }

        if (seconds >= 13 && seconds < 14)
        {
            if (count >= 1)
            {
                count = 0;
                AppearTcom8();
            }

        }

        if (seconds >= 14 && seconds < 15)
        {
            if (count >= 1)
            {
                count = 0;
                AppearTcom9();
            }

        }

        if (seconds >= 16 && seconds < 17)
        {
            if (count >= 1)
            {
                count = 0;
                ToClear();
            }

        }



    }

    //開始時の一連の処理
    void AppearTcom1()
    {
        audioSource.PlayOneShot(soundSE);
        tcom1.SetActive(true);
    }

    void AppearTcom2()
    {
        audioSource.PlayOneShot(soundSE);
        tcom2.SetActive(true);
    }

    void AppearTcom3()
    {
        audioSource.PlayOneShot(soundSE);
        tcom3.SetActive(true);
        commentsAppear = true;
    }

    void FirstAttack()
    {
        if (tcom1 != null && seconds >= 4.5 && commentsAppear && tcom2 != null && tcom3 != null)
        {
            tcom1.transform.position += new Vector3(0.1f, 0, 0);
            if (tcom1.transform.position.x > 4)
            {
                GameObject.Destroy(tcom1);
            }
            tcom2.transform.position += new Vector3(0.1f, 0, 0);
            if (tcom2.transform.position.x > 4)
            {
                GameObject.Destroy(tcom2);
            }
            tcom3.transform.position += new Vector3(0.1f, 0, 0);
            if (tcom3.transform.position.x > 4)
            {
                GameObject.Destroy(tcom3);
            }
        }

    }

    void AppearTcom4()
    {
        audioSource.PlayOneShot(soundSE);
        tcom4Object = Instantiate(tcom4, new Vector3(-1.8f, 3f, 0), Quaternion.identity) as GameObject;
    }

    void AppearTcom5()
    {
        audioSource.PlayOneShot(soundSE);
        tcom5Object = Instantiate(tcom5, new Vector3(-1.7f, 2.3f, 0), Quaternion.identity) as GameObject;
    }

    void AppearTcom6()
    {
        audioSource.PlayOneShot(soundSE);
        tcom6Object = Instantiate(tcom6, new Vector3(-1.5f, 1.6f, 0), Quaternion.identity) as GameObject;
    }


    void SeccondAttack()
    {
        if (tcom4Object != null &&  tcom5Object != null && tcom6Object != null)
        {
            tcom4Object.transform.position += new Vector3(0.1f, 0, 0);
            if (tcom4Object.transform.position.x > 4)
            {
                GameObject.Destroy(tcom4Object);
            }
            tcom5Object.transform.position += new Vector3(0.1f, 0, 0);
            if (tcom5Object.transform.position.x > 4)
            {
                GameObject.Destroy(tcom5Object);
            }
            tcom6Object.transform.position += new Vector3(0.1f, 0, 0);
            if (tcom6Object.transform.position.x > 4)
            {
                GameObject.Destroy(tcom6Object);
            }
        }

    }

    void AppearTcom7()
    {
        audioSource.PlayOneShot(soundSE);
        Instantiate(tcom7, new Vector3(-1.5f, 3f, 0), Quaternion.identity);
    }

    void AppearTcom8()
    {
        audioSource.PlayOneShot(soundSE);
        Instantiate(tcom8, new Vector3(-1.7f, 2.3f, 0), Quaternion.identity);
    }

    void AppearTcom9()
    {
        audioSource.PlayOneShot(soundSE);
        Instantiate(tcom9, new Vector3(-1.55f, 1.6f, 0), Quaternion.identity);
    }

    void ToClear()
    {
        SceneManager.LoadScene("TutorialClear");
    }

}
