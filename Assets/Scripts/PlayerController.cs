using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
<<<<<<< HEAD
    private Rigidbody2D rigidbody;
=======
    public Rigidbody2D myRigidbody;
>>>>>>> develop

    public float jumpSpeed;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

<<<<<<< HEAD
    public bool isGrounded;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
=======
    public bool isGround;

    private Animator animator;

    public Vector3 respwanPosition;

    public LevelManagerController levelManagerController;

    void Start()
    {

        myRigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        respwanPosition = transform.position;
        levelManagerController = FindObjectOfType<LevelManagerController>();
>>>>>>> develop
    }

    void Update()
    {
<<<<<<< HEAD
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        //if (Input.GetKey(KeyCode.D))
        if (Input.GetAxisRaw("Horizontal") > 0f)
        {
            rigidbody.velocity = new Vector3(moveSpeed, rigidbody.velocity.y, 0f);
        }

        else if (Input.GetAxisRaw("Horizontal") < 0f)
        {
            rigidbody.velocity = new Vector3(-moveSpeed, rigidbody.velocity.y, 0f);
        }
        else
        {
            rigidbody.velocity = new Vector3(0f, rigidbody.velocity.y, 0f);
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rigidbody.velocity = new Vector3(rigidbody.velocity.x, jumpSpeed, 0f);
=======
        isGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        if (Input.GetAxisRaw("Horizontal") > 0f)
        {
            myRigidbody.velocity = new Vector3(moveSpeed, myRigidbody.velocity.y, 0f);
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else if (Input.GetAxisRaw("Horizontal") < 0f)
        {
            myRigidbody.velocity = new Vector3(-moveSpeed, myRigidbody.velocity.y, 0f);
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else
        {
            myRigidbody.velocity = new Vector3(0f, myRigidbody.velocity.y, 0f);
        }


        if (Input.GetButtonDown("Jump") && isGround)
        {
            myRigidbody.velocity = new Vector3(myRigidbody.velocity.x, jumpSpeed, 0f);
        }

        animator.SetFloat("Speed", Mathf.Abs(myRigidbody.velocity.x));
        animator.SetBool("Grounded", isGround);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "KillPlane")
        {
            // gameObject.SetActive(false);
            // transform.position = respwanPosition;
            levelManagerController.Respawn();
        }

        if(collision.tag == "CheckPoint")
        {
            respwanPosition = collision.transform.position;
>>>>>>> develop
        }
    }
}
