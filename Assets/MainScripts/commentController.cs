using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class commentController : MonoBehaviour
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

        if(seconds > 1)
        {
            CommentMove();
        }
    }

    void CommentMove()
    {
        if (this.gameObject != null)
        {
            this.transform.position += new Vector3(0.1f, 0, 0);
            if (this.transform.position.x > 4)
            {
                GameObject.Destroy(this.gameObject);
            }
        }
    }


}
