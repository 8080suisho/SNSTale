using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potatobeem3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, 270);
        transform.position += new Vector3(0, -0.1f, 0);
        if (this.transform.position.y < -5.5)
        {
            GameObject.Destroy(this.gameObject);
        };
    }
}
