using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-0.07f, 0, 0);
        if (this.transform.position.x < -5.5)
        {
            GameObject.Destroy(this.gameObject);
        }
    }
}
