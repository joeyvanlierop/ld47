using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Spawn Locations
    private Vector3 playerSpawn = new Vector3(0, -0.95f, 0);
    private Vector3 playerScale = new Vector3(0.1f, 0.1f, 1);

    private float radSpeed = 0.1f;
    private float radPos = 0;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = playerSpawn;
        transform.localScale = playerScale;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (Input.GetKey("d")) {
            radPos += radSpeed;
            transform.position += new Vector3(Mathf.Cos(radPos), Mathf.Sin(radPos), 0);

        }
    }
}
