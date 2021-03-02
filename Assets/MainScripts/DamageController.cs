using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageController : MonoBehaviour
{
    Image img;
    GameObject playerController;
    PlayerController script;
    
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player");
        script = playerController.GetComponent<PlayerController>();

        img = GetComponent<Image>();
        img.color = Color.clear;
    }

    // Update is called once per frame
    void Update()
    {
        bool playerDamage = script.damageFlag;
        
        if (playerDamage)
        {
            this.img.color = new Color(0.5f, 0f, 0f, 0.5f);
        }
        else
        {
            this.img.color = Color.Lerp(this.img.color, Color.clear, Time.deltaTime);
        }
    }
}
