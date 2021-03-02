using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController: MonoBehaviour
{
    Rigidbody2D rigid2d;
    
    public Text hPText;
    public float speed;
    int hP = 100;

    Vector3 playerPosition;
    bool clickSwitch = false;

    public AudioClip soundSE;
    public AudioClip cureSE;
    private AudioSource audioSourceSE;

    public bool damageFlag = false;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSourceSE = gameObject.GetComponent<AudioSource>();
        audioSourceSE.clip = soundSE;

    }

    // Update is called once per frame
    void Update()
    {
        //Touch touch = Input.GetTouch(0);
        //touch.phase == TouchPhase.Began
        //
        //マウスに追従させる
        if (Input.GetMouseButton(0))
        {
            playerPosition = Input.mousePosition;
            clickSwitch = true;
        }


        if (clickSwitch)
        {
            Vector3 pd = Camera.main.ScreenToWorldPoint(playerPosition) - this.transform.position;
            Vector3 pn = pd.normalized;

            pn = new Vector3(pn.x, pn.y, 0);

            this.transform.position += pn * speed * Time.deltaTime;

            float angle = Vector3.Angle(new Vector3(0, 1, 0), pn);
            if (pn.x > 0) angle = -angle;
            this.transform.rotation = Quaternion.Euler(this.transform.rotation.x, this.transform.rotation.y, angle);
        }


        //カメラ範囲外に出ないようにする処理
        transform.position = new Vector3(
            //エリア指定して移動する
            Mathf.Clamp(transform.position.x, -2.5f, 2.5f),
            Mathf.Clamp(transform.position.y, -4.5f, 3.6f),
            0f);

        //HPが0になったらゲームオーバー
        if(hP <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }

        damageFlag = false;
        
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Bullet")
        {
            audioSourceSE.Play();
            this.hP -= 20;
            hPText.text = "しんらい : " + hP.ToString();
            damageFlag = true;
        }

        if (coll.gameObject.tag == "Cure")
        {
            audioSourceSE.PlayOneShot(cureSE);
            this.hP += 20;
            hPText.text = "しんらい : " + hP.ToString();
            
        }

    }

}
