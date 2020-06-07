using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    Animator anim;
    Rigidbody rb;

    bool facingRight;

    bool grounded = false;
    Collider[] groundCollisions;
    float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;
    public Transform groundCheck;

    public Vector3 spawnPoint;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        facingRight = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GroundCollision();
        Falling();
        float move;
        if (Application.platform == RuntimePlatform.Android)
        {
            move = Input.acceleration.x * 2;           
            Movement(move);            
        }
        else
        {
            move = Input.GetAxis("Horizontal");
            Movement(move);
        }
        

    }

    void Movement (float move)
    {
        if (grounded)
        {
            anim.SetFloat("speed", Mathf.Abs(move));
        }
        
        rb.velocity = new Vector3(move * speed, rb.velocity.y, 0);

        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 scale = transform.localScale;
        scale.z *= -1;
        transform.localScale = scale;
    }

    void GroundCollision()
    {
        groundCollisions = Physics.OverlapSphere(groundCheck.position, groundCheckRadius, groundLayer);

        if (groundCollisions.Length > 0)
            grounded = true;
        else
            grounded = false;

        anim.SetBool("grounded", grounded);
    }

    void Falling()
    {
        float verticalSpeed = rb.velocity.y;
        if (verticalSpeed > 0)
            anim.SetBool("fallingUp", true);
        else if (verticalSpeed < 0)
            anim.SetBool("fallingUp", false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Platform"))
        {
            Vector3 offset = new Vector3(0, 10, 0);
            spawnPoint = collision.transform.position + offset;
        }
    }
    
}
