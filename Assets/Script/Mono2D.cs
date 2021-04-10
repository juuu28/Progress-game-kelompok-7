using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Mono2D : MonoBehaviour
{
    
    [SerializeField] public float moveSpeed;
    [SerializeField] public float jumpForce;
    [SerializeField] public bool isGrounded = false;
    [SerializeField] public bool isWalled = false;
    [SerializeField] protected Rigidbody2D rb;
    [SerializeField] protected Vector2 direction;
    [SerializeField] protected KeyCode moveLeft;
    [SerializeField] protected KeyCode moveRight;
    [SerializeField] protected KeyCode moveUp;
    [SerializeField] protected KeyCode moveDown;
    [SerializeField] protected KeyCode jumpCode;
    /*[SerializeField] protected float inputVertical;
    [SerializeField] protected LayerMask whatIsLadder;
    [SerializeField] protected bool isClimbing;
    [SerializeField] protected float distance;*/
    protected float lockPos = 0;
    protected InputSystem control;
    protected float inputAxis;
    [SerializeField] protected Animator animator;
    AudioSource audioSrc;
    [SerializeField] protected bool isMoving;
    public bool onLadder;


    public void Init()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    public void Move(float _direction)
    {
        //animator.SetBool("run", true);
        if (_direction != 0)
        {
            animator.SetBool("walk", true);
            
        }
        else
        {
            animator.SetBool("walk", false);
            
        }
        /*if (_direction != 0)
        {
            audioSrc.Play();
        }
        else
        { 
            audioSrc.Stop();
        }*/
        direction.x = _direction;
        transform.Translate(direction * moveSpeed * Time.deltaTime);
        //animator.SetFloat("Speed", Mathf.Abs(inputAxis));
        ChangeFlip();
    }
    public void ChangeFlip()
    {
        if (direction.x > 0)
        {
            transform.localScale = new Vector3(1.25f, 1.25f, 1);
        }
        if (direction.x < 0)
        {
            transform.localScale = new Vector3(-1.25f, 1.25f, 1);
        }
    }
    private void Awake()
    {
        control = new InputSystem();
        control.Player.Movements.performed += ctx => inputAxis = ctx.ReadValue<float>();
        control.Player.Movements.canceled += ctx => inputAxis = 0;
    }
    private void OnEnable()
    {
        control.Enable();
    }

    private void OnDisable()
    {
        control.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        Init();
        audioSrc = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);
        //Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        //transform.position += movement * Time.deltaTime * moveSpeed;
        //InputGetKeyMovement();

        //InputGetAxisMovement();
        Move(inputAxis);
        Jump();
        //InputGetKeyJump();
        //InputGetAxisJump();
        //Climb();


    }
    public void InputGetKeyMovement()
    {
        if (Input.GetKey(moveLeft))
        {
            //direction.x = -1;
            Move(-1);
        }
        if (Input.GetKey(moveRight))
        {
            //direction.x = 1;
            Move(1);
        }
        /*if (Input.GetKey(moveUp))
        {
            direction.y = 1;
            //Move(-1);
        }
        if (Input.GetKey(moveDown))
        {
            direction.y = -1;
            //Move(1);
        }*/
    }
    public void InputGetAxisMovement()
    {
        direction.x = Input.GetAxis("Horizontal");
        Move(direction.x);
    }


    public void Jump()
    {
        
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            if (isGrounded == false && onLadder ==false)
            {
                animator.SetBool("jump", true );
            }
            else if(isGrounded == false && onLadder == true)
            {
                animator.SetBool("jump", false);
            }
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ladder") /*&& Input.GetKey(KeyCode.W)*/)
        {
            animator.SetBool("climb", true);
        }
        else if (collision.CompareTag("Ladder") /*&& Input.GetKey(KeyCode.S)*/)
        {
            animator.SetBool("climb", true);
        }
        else
        {
            animator.SetBool("climb", false);
        }

    }
    /*public void dead()
    {
        if (HealthBar.health == 0)
        {

        }
    }*/
}
