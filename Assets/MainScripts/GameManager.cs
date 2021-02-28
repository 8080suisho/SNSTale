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
    public GameObject lieBlock;
    public GameObject doubtBullet;

    public AudioClip soundSE;
    private AudioSource audioSourceSE;

    bool commentsAppear = false;
    bool firstAttackEnd = false;
   

    float seconds;
    float count;

    // Start is called before the first frame update
    void Start()
    {
        audioSourceSE = gameObject.GetComponent<AudioSource>();
        audioSourceSE.clip = soundSE;

        Invoke("AppearComment1", 1);
        Invoke("AppearComment2", 2);
        Invoke("AppearComment3", 3);
        Invoke("AppearComment4", 4);

        
    }

    // Update is called once per frame
    void Update()
    {
        int randomTime = Random.Range(1, 3);
        seconds += Time.deltaTime;
        count += Time.deltaTime;

        if (!firstAttackEnd)
        {
            FirstAttack();
        }
        if (firstAttackEnd && seconds >= 6 && seconds < 11)
        {
            if(count >= 1)
            {
                count = 0;
                GenLie();
            }
        }
        if (firstAttackEnd && seconds >= 10 && seconds < 20)
        {
            if (count >= 2)
            {
                count = 0;
                GenDoubt();
            }
        }


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
        commentsAppear = true;
    }

    void FirstAttack()
    {
        if (comment1 != null && seconds >= 5 && commentsAppear)
        {
            comment1.transform.position += new Vector3(0.1f, 0, 0);
            if (comment1.transform.position.x > 4)
            {
                GameObject.Destroy(comment1);
            }
        }

        if (comment2 != null && seconds >= 5.2f && commentsAppear)
        {
            comment2.transform.position += new Vector3(0.1f, 0, 0);
            if (comment2.transform.position.x > 4)
            {
                GameObject.Destroy(comment2);
            }
        }

        if (comment3 != null && seconds >= 5.4f && commentsAppear)
        {
            comment3.transform.position += new Vector3(0.1f, 0, 0);
            if (comment3.transform.position.x > 4)
            {
                GameObject.Destroy(comment3);
            }
        }

        if (comment4 != null && seconds >= 5.6f && commentsAppear)
        {
            comment4.transform.position += new Vector3(0.1f, 0, 0);
            if (comment4.transform.position.x > 4)
            {
                GameObject.Destroy(comment4);
                firstAttackEnd = true;
            }
        }
    }

    void GenLie()
    {
        Instantiate(lieBlock, new Vector3(-2.5f + 4.3f * Random.value, 6, 0), Quaternion.identity);
    }

    void GenDoubt()
    {
        Instantiate(doubtBullet, new Vector3(0, 6, 0), Quaternion.identity);
    }

    
}
