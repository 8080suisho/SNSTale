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
    public GameObject trueBullet;
    public GameObject liarBullet;
    public GameObject lip;
    public GameObject alert1;
    public GameObject alert2;
    public GameObject alert3;

    private GameObject alert2Object;
    private GameObject alert3Object;
    private GameObject alert3Object2;
    private GameObject alert3Object3;

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
        

        Invoke("AppearComment1", 1);
        Invoke("AppearComment2", 2);
        Invoke("AppearComment3", 3);
        Invoke("AppearComment4", 4);
        Invoke("BGMPlay", 5);

    }

    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime;
        count += Time.deltaTime;
        
        FirstAttack();
        
        if (firstAttackEnd && seconds >= 6 && seconds < 11)
        {
            if(count >= 1)
            {
                count = 0;
                GenLie();
            }
        }
        if (seconds >= 10 && seconds < 20)
        {
            if (count >= 2)
            {
                count = 0;
                GenDoubt();
            }
        }
        if (seconds >= 24 && seconds < 26)
        {
            if(count >= 2)
            {
                count = 0;
                AppearAlert2();
            }
        }
        if (seconds >= 26f && seconds < 26.1f)
        {
            if (count >= 0.1f)
            {
                count = 0;
                BreakAlert2();
            }
        }
        if (seconds >= 26.1f && seconds < 26.2f)
        {
            if (count >= 0.1f)
            {
                count = 0;
                CommentRush();
            }
        }
        if (seconds >= 29f && seconds < 31)
        {
            if (count >= 2)
            {
                count = 0;
                AppearAlert3();
            }
        }
        if (seconds >= 31f && seconds < 31.1f)
        {
            if (count >= 0.1f)
            {
                count = 0;
                BreakAlert3();
            }
        }
        if (seconds >= 31.1f && seconds < 31.2f)
        {
            if (count >= 0.1f)
            {
                count = 0;
                LipMissile();
            }
        }
        if (seconds >= 32 && seconds < 40)
        {
            if (count >= 1)
            {
                count = 0;
                GenLie();
            }
        }


    }



    //開始時の一連の処理
    void AppearComment1()
    {
        audioSource.PlayOneShot(soundSE);
        comment1.SetActive(true);
    }

    void AppearComment2()
    {
        audioSource.PlayOneShot(soundSE);
        comment2.SetActive(true);
    }

    void AppearComment3()
    {
        audioSource.PlayOneShot(soundSE);
        comment3.SetActive(true);
    }

    void AppearComment4()
    {
        audioSource.PlayOneShot(soundSE);
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

    //嘘攻撃
    void GenLie()
    {
        Instantiate(lieBlock, new Vector3(-2f + 4.3f * Random.value, 6, 0), Quaternion.identity);
    }

    //うたがい攻撃
    void GenDoubt()
    {
        Instantiate(doubtBullet, new Vector3(0, 6, 0), Quaternion.identity);
    }

    //コメント包囲網
    void CommentRush()
    {
        audioSource.PlayOneShot(soundSE);
        Instantiate(liarBullet, new Vector3(-2f, 3.7f, 0), Quaternion.identity);
        Instantiate(liarBullet, new Vector3(-2f, 3f, 0), Quaternion.identity);
        Instantiate(trueBullet, new Vector3(-2f, 2.3f, 0), Quaternion.identity);
        Instantiate(liarBullet, new Vector3(-2f, 1.6f, 0), Quaternion.identity);
        Instantiate(liarBullet, new Vector3(-2f, 0.9f, 0), Quaternion.identity);
        Instantiate(liarBullet, new Vector3(-2f, 0.2f, 0), Quaternion.identity);
        Instantiate(liarBullet, new Vector3(-2f, -0.5f, 0), Quaternion.identity);
        Instantiate(liarBullet, new Vector3(-2f, -1.2f, 0), Quaternion.identity);
        Instantiate(liarBullet, new Vector3(-2f, -1.9f, 0), Quaternion.identity);
        Instantiate(liarBullet, new Vector3(-2f, -2.6f, 0), Quaternion.identity);
        Instantiate(trueBullet, new Vector3(-2f, -3.3f, 0), Quaternion.identity);
        Instantiate(liarBullet, new Vector3(-2f, -4f, 0), Quaternion.identity);
        Instantiate(liarBullet, new Vector3(-2f, -4.7f, 0), Quaternion.identity);
    }

    //口紅発射
    void LipMissile()
    {
        Instantiate(lip, new Vector3(2f, -6.5f, 0), Quaternion.identity);
        Instantiate(lip, new Vector3(0f, -6.5f, 0), Quaternion.identity);
        Instantiate(lip, new Vector3(-2f, -6.5f, 0), Quaternion.identity);
    }
    

    //BGM
    void BGMPlay()
    {
        audioSource.PlayOneShot(battleBGM);
    }


    //アラート表示
    void AppearAlart1()
    {

    }

    void AppearAlert2()
    {
        alert2Object = Instantiate(alert2, new Vector3(-1.6f, -0.4f, 0), Quaternion.identity) as GameObject;
    }

    void AppearAlert3()
    {
        alert3Object = Instantiate(alert3, new Vector3(2f, -4f, 0), Quaternion.identity) as GameObject;
        alert3Object2 = Instantiate(alert3, new Vector3(0f, -4f, 0), Quaternion.identity) as GameObject;
        alert3Object3 = Instantiate(alert3, new Vector3(-2f, -4f, 0), Quaternion.identity) as GameObject;
    }


    //アラート削除
    void BreakAlert1()
    {

    }

    void BreakAlert2()
    {
        GameObject.Destroy(alert2Object);
    }

    void BreakAlert3()
    {
        GameObject.Destroy(alert3Object);
        GameObject.Destroy(alert3Object2);
        GameObject.Destroy(alert3Object3);
    }
    
}
