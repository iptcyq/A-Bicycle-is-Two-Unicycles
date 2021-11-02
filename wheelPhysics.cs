using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheelPhysics : MonoBehaviour
{
    public float speed = 1f;
    public float jumpForce = 5f;
    private float moveInput;

    private Rigidbody2D rb;

    [Space]
    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatsIsGround;

    [Space]
    public float decel = -1f;
    private float velocity;

    [Space]
    public bool frontwheel;

    [Space]
    public bool sound = false;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();
        sound = false;
}

    // Update is called once per frame
    void FixedUpdate()
    {
        //jump
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatsIsGround);
        //decelerate
        if(velocity > 0)
        {
            velocity += decel * Time.deltaTime;
        }
        //move
        if (frontwheel){moveInput = Input.GetAxisRaw("HorizontalFront");}
        else{moveInput = Input.GetAxisRaw("HorizontalBack");}

        velocity += moveInput * speed;
        rb.velocity = new Vector2(velocity, rb.velocity.y);
        
        
        if(moveInput != 0)
        {
            if (sound == false)
            {
                FindObjectOfType<audioManager>().Play("pedalling");
                sound = true;
            }
        }
        else
        {
            FindObjectOfType<audioManager>().Stop("pedalling");
            sound = false;
        }
    
    }

    private void Update()
    {
        //jump
        if(Input.GetKeyDown(KeyCode.UpArrow) && isGrounded &&frontwheel)
        {
            FindObjectOfType<audioManager>().Play("bell");
            rb.velocity = Vector2.up * jumpForce;
        }
        if (Input.GetKeyDown(KeyCode.W) && isGrounded && !frontwheel)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }
}
