using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotdogSpin : MonoBehaviour
{
    float seconds;
    float count;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime;
        count += Time.deltaTime;

        if(count < 5)
        {
            transform.Rotate(0, 0, 1.5f);
        }
        if(count >= 5)
        {
            transform.Rotate(0, 0, -1.5f);
        }
    }
}
