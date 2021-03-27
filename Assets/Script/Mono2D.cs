using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Mono2D : MonoBehaviour
{

    [SerializeField] public float moveSpeed;
    [SerializeField] public float jumpForce;
    public bool isGrounded = false;
    [SerializeField] protected Rigidbody2D rb;
    [SerializeField] protected Vector2 direction;
    [SerializeField] protected KeyCode moveLeft;
    [SerializeField] protected KeyCode moveRight;
    [SerializeField] protected KeyCode jumpCode;
    protected InputSystem control;
    protected float inputAxis;


    public void Init()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void Move(float _direction)
    {
        direction.x = _direction;
        transform.Translate(direction * moveSpeed * Time.deltaTime);
        ChangeFlip();
    }
    public void ChangeFlip()
    {
        if (direction.x > 0)
        {
            transform.localScale = new Vector3(-5, 5, 1);
        }
        if (direction.x < 0)
        {
            transform.localScale = new Vector3(5, 5, 1);
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
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        //Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        //transform.position += movement * Time.deltaTime * moveSpeed;
        //InputGetKeyMovement();

        //InputGetAxisMovement();
        Move(inputAxis);
        //InputGetKeyJump();
        //InputGetAxisJump();
        
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
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }
}
