using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheBestScript : MonoBehaviour
{

    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("a"))
        {
            transform.position += new Vector3(-0.1f, 0);
        }

        if (Input.GetKey("d"))
        {
            transform.position += new Vector3(0.1f, 0);
        }
    }
}
