using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager2 : MonoBehaviour
{
    public GameObject comment2_1;
    public GameObject comment2_2;
    public GameObject comment2_3;
    public GameObject comment2_4;

    public GameObject foodBullet;
    public GameObject foodBullet2;

    public AudioClip soundSE;
    public AudioClip battleBGM;

    private AudioSource audioSource;

    bool commentsAppear = false;
    bool firstAttackEnd = false;

    float seconds;
    float count;

    // Start is called before the first frame update
    void Start()
    {

        audioSource = gameObject.GetComponent<AudioSource>();


        Invoke("AppearComment2_1", 1);
        Invoke("AppearComment2_2", 2);
        Invoke("AppearComment2_3", 3);
        Invoke("AppearComment2_4", 4);
        Invoke("BGMPlay", 5);

    }

    // Update is called once per frame
    void Update()
    {

        seconds += Time.deltaTime;
        count += Time.deltaTime;

        FirstAttack();

        if (firstAttackEnd && seconds >= 8 && seconds < 9)
        {
            if (count >= 1)
            {
                count = 0;
                FoodStrike();
            }
        }
        if (firstAttackEnd && seconds >= 10 && seconds < 11)
        {
            if (count >= 1)
            {
                count = 0;
                FoodStrike2();
            }
        }
        if (firstAttackEnd && seconds >= 12 && seconds < 13)
        {
            if (count >= 1)
            {
                count = 0;
                FoodStrike();
            }
        }
        if (firstAttackEnd && seconds >= 14 && seconds < 15)
        {
            if (count >= 1)
            {
                count = 0;
                FoodStrike2();
            }
        }

    }



    //開始時の一連の処理
    void AppearComment2_1()
    {
        audioSource.PlayOneShot(soundSE);
        comment2_1.SetActive(true);
    }

    void AppearComment2_2()
    {
        audioSource.PlayOneShot(soundSE);
        comment2_2.SetActive(true);
    }

    void AppearComment2_3()
    {
        audioSource.PlayOneShot(soundSE);
        comment2_3.SetActive(true);
    }

    void AppearComment2_4()
    {
        audioSource.PlayOneShot(soundSE);
        comment2_4.SetActive(true);
        commentsAppear = true;
    }

    void FirstAttack()
    {
        if (comment2_1 != null && seconds >= 5 && commentsAppear)
        {
            comment2_1.transform.position += new Vector3(0.1f, 0, 0);
            if (comment2_1.transform.position.x > 4)
            {
                GameObject.Destroy(comment2_1);
            }
        }

        if (comment2_2 != null && seconds >= 5.2f && commentsAppear)
        {
            comment2_2.transform.position += new Vector3(0.1f, 0, 0);
            if (comment2_2.transform.position.x > 4)
            {
                GameObject.Destroy(comment2_2);
            }
        }

        if (comment2_3 != null && seconds >= 5.4f && commentsAppear)
        {
            comment2_3.transform.position += new Vector3(0.1f, 0, 0);
            if (comment2_3.transform.position.x > 4)
            {
                GameObject.Destroy(comment2_3);
            }
        }

        if (comment2_4 != null && seconds >= 5.6f && commentsAppear)
        {
            comment2_4.transform.position += new Vector3(0.1f, 0, 0);
            if (comment2_4.transform.position.x > 4)
            {
                GameObject.Destroy(comment2_4);
                firstAttackEnd = true;
            }
        }


    }


    //BGM
    void BGMPlay()
    {
        audioSource.PlayOneShot(battleBGM);
    }

    //ハンバーガーミサイル
    void FoodStrike()
    {
        Instantiate(foodBullet, new Vector3(-3.5f, 3.2f, 0), Quaternion.identity);
        Instantiate(foodBullet, new Vector3(-3.5f, 0.6f, 0), Quaternion.identity);
        Instantiate(foodBullet, new Vector3(-3.5f, -2, 0), Quaternion.identity);
    }

    void FoodStrike2()
    {
        Instantiate(foodBullet2, new Vector3(3.5f, 1.9f, 0), Quaternion.identity);
        Instantiate(foodBullet2, new Vector3(3.5f, -0.7f, 0), Quaternion.identity);
        Instantiate(foodBullet2, new Vector3(3.5f, -3.3f, 0), Quaternion.identity);
    }

}
