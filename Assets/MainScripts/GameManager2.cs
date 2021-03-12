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
    public GameObject potatobeem1;
    public GameObject potatobeem2;
    public GameObject potatobeem3;
    public GameObject potatobeem4;
    public GameObject potatocase;
    public GameObject hotdog;
    public GameObject alert2;
    public GameObject dropFood;
    public GameObject dropCureFood;
    public GameObject potatoWall;

    private GameObject potatocaseObject;
    private GameObject hotdogObject;
    private GameObject alert2Object;


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
        if (seconds >= 17 && seconds < 18)
        {
            if (count >= 1)
            {
                count = 0;
                AppearPotatocase();
               
            }
        }
        if (seconds >= 18 && seconds < 26)
        {
            if (count >= 1.5)
            {
                count = 0;
                Potatobeem1();
                Potatobeem2();

            }
        }
        if (seconds >= 27 && seconds < 28)
        {
            if (count >= 1)
            {
                count = 0;
                BreakPotatocase();
            }
        }
        if (seconds >= 28 && seconds < 35)
        {
            if (count >= 1.5)
            {
                count = 0;
                PotatoBar();
            }
        }
        if (seconds >= 37 && seconds < 38)
        {
            if (count >= 1)
            {
                count = 0;
                AppearAlert2();
            }
        }
        if (seconds >= 38 && seconds < 39)
        {
            if (count >= 1)
            {
                count = 0;
                BreakAlert2();
            }
        }
        if (seconds >= 39 && seconds < 40)
        {
            if (count >= 1)
            {
                count = 0;
                AppearHotdog();
            }
        }
        if (seconds >= 50 && seconds < 51)
        {
            if (count >= 1)
            {
                count = 0;
                BreakHotdog();
            }
        }

        if (seconds >= 52 && seconds < 60)
        {
            if (count >= 1)
            {
                count = 0;
                float randomCure = Random.value;
                if(randomCure > 0.7)
                {
                    GenCureFood();
                }
                else
                {
                    GenFood();
                }
            }
        }

        if (seconds >= 62 && seconds < 70)
        {
            if (count >= 1)
            {
                count = 0;
                GenPotatoWall();
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
        Instantiate(foodBullet, new Vector3(-3.5f, 2.8f, 0), Quaternion.identity);
        Instantiate(foodBullet, new Vector3(-3.5f, 0.2f, 0), Quaternion.identity);
        Instantiate(foodBullet, new Vector3(-3.5f, -2.4f, 0), Quaternion.identity);
    }

    void FoodStrike2()
    {
        Instantiate(foodBullet2, new Vector3(3.5f, 1.5f, 0), Quaternion.identity);
        Instantiate(foodBullet2, new Vector3(3.5f, -1.1f, 0), Quaternion.identity);
        Instantiate(foodBullet2, new Vector3(3.5f, -3.7f, 0), Quaternion.identity);
    }

    //ポテトビーム

    //ケース表示
    void AppearPotatocase()
    {
        potatocaseObject = Instantiate(potatocase, new Vector3(0, -4, 0), Quaternion.identity) as GameObject;
    }

    //ケース削除
    void BreakPotatocase()
    {
        GameObject.Destroy(potatocaseObject);
    }

    //ポテト生成
    void Potatobeem1()
    {
        Instantiate(potatobeem1, new Vector3(-2f + 4.3f * Random.value, -6, 0), Quaternion.identity);
    }

    void Potatobeem2()
    {
        Instantiate(potatobeem2, new Vector3(-2f + 4.3f * Random.value, -6, 0), Quaternion.identity);
        Instantiate(potatobeem2, new Vector3(-2f + 4.3f * Random.value, -6, 0), Quaternion.identity);
    }

    //ポテトアゲイン

    //ポテト生成
    void PotatoBar()
    {
        Instantiate(potatobeem3, new Vector3(-1.75f, 7, 0), Quaternion.identity);
        Instantiate(potatobeem4, new Vector3(1.75f, 11.5f, 0), Quaternion.identity);
    }


    //ホットドッグ風車
    void AppearHotdog()
    {
        hotdogObject = Instantiate(hotdog, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
    }

    //ホットドッグ削除
    void BreakHotdog()
    {
        GameObject.Destroy(hotdogObject);
    }

    //アラート
    void AppearAlert2()
    {
        alert2Object = Instantiate(alert2, new Vector3(0f, -0.4f, 0), Quaternion.identity) as GameObject;
    }

    //アラート削除
    void BreakAlert2()
    {
        GameObject.Destroy(alert2Object);
    }

    //ハンバーガー隕石

    void GenFood()
    {
        Instantiate(dropFood, new Vector3(-2f + 4.3f * Random.value, 6, 0), Quaternion.identity);
    }

    void GenCureFood()
    {
        Instantiate(dropCureFood, new Vector3(-2f + 4.3f * Random.value, 6, 0), Quaternion.identity);
    }

    //ポテト壁

    void GenPotatoWall()
    {
        Instantiate(potatoWall, new Vector3(-15,9, 0), Quaternion.identity);
    }
}
