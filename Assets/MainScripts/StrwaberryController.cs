using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrwaberryController : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, -0.01f, 0);
        if (this.transform.position.y < -5.5)
        {
            GameObject.Destroy(this.gameObject);
        }
    }
}
