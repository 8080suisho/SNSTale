using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageController2 : MonoBehaviour
{
    Image img;
    GameObject playerController2;

    PlayerController2 script2;

    // Start is called before the first frame update
    void Start()
    {
        playerController2 = GameObject.Find("Player2");
        script2 = playerController2.GetComponent<PlayerController2>();

        img = GetComponent<Image>();
        img.color = Color.clear;
    }

    // Update is called once per frame
    void Update()
    {
        bool playerDamage2 = script2.damageFlag2;
        bool playerCure2 = script2.cureFlag2;


        if (playerDamage2)
        {
            this.img.color = new Color(0.5f, 0f, 0f, 0.5f);
        }
        if (playerCure2)
        {
            this.img.color = new Color(0f, 0.5f, 0f, 0.5f);
        }
        else
        {
            this.img.color = Color.Lerp(this.img.color, Color.clear, Time.deltaTime);
        }
    }
}
