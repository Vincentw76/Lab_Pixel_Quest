using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float JumpForce = 10f;
    //Capsule
    public float CapsuleHeight = 0.25f;
    public float CapsuleRadius = 0.08f;

    //Ground Check
    public Transform feetCollider;
    public LayerMask groundMask;
    private bool _groundCheck;
    private float fallForce = 4;
    private Vector2 gravityForce;
    public float jumpForce = 10f;

    private bool waterCheck;
    // Start is called before the first frame update
    void Start()
    {
        gravityForce = new Vector2(0f, Physics2D.gravity.y);
       rb = GetComponent<Rigidbody2D>();                       
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Water")
        {
            waterCheck = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Water")
        {
            waterCheck = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
      
        _groundCheck = Physics2D.OverlapCapsule(feetCollider.position,
            new Vector2(CapsuleHeight, CapsuleRadius), CapsuleDirection2D.Horizontal,
             0, groundMask);
        if (Input.GetKeyDown(KeyCode.Space) &&(_groundCheck || waterCheck))
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpForce);
        }
        if (rb.velocity.x > 0)
        {
            rb.velocity += gravityForce * (fallForce * Time.deltaTime);        
                }

        
    }
}
