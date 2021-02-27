using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LieController : MonoBehaviour
{
    float fallSpeed;
    float rotSpeed;

    // Start is called before the first frame update
    void Start()
    {
        this.fallSpeed = 0.01f + 0.1f * Random.value;
        this.rotSpeed = 1f + 1f * Random.value;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -fallSpeed, 0, Space.World);
        transform.Rotate(0, 0, rotSpeed);

        if (transform.position.y < -5.5f)
        {
            Destroy(this.gameObject);
        }
    }
}
