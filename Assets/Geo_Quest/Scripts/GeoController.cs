using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using Unity.VisualScripting.FullSerializer;
using UnityEditor;
using UnityEngine;

public class GeoController : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Hit");
    }
    public int speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    

    // Update is called once per frame
    void Update()
    {
        /*
        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2 (xInput * speed, rb.velocity.y);
        /*
            if (Input.GetKeyDown(KeyCode.D))
            {
                rb.velocity = new Vector2(1, rb.velocity.y);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                transform.position += new Vector3(0, -1, 0);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                rb.velocity = new Vector2(-1, rb.velocity.y);
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                transform.position += new Vector3(0, 1, 0);
            }
        
    }
}
