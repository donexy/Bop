using System;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
    
public class NewMonoBehaviourScript : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] float baseSpeed;
    [SerializeField] float shiftSpeed = 1.5f;

    [Header("Jump")]
    [SerializeField] float jumpPower = 2f;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] Transform _jumpArea;
    [SerializeField] float _radius;
    [SerializeField] float jumpGravity;
    [SerializeField] float fallGravity;

    [Header("Audio")]
    [SerializeField] AudioSource jumpAudio;
    [SerializeField] AudioClip jumpClip;
  


    [Header("Other")]
    [SerializeField] bool autoMove = false;



    private float _currentSpeed;
    private Rigidbody2D _rb;
    private float jumpCooldown = .45f;
    private float lastJumpTime;
    private bool isFirstLocation = false;





    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();

    }

    void FixedUpdate()
    {
        if(autoMove == false)
        {
            PlayerMovement();

        }

        else if (autoMove == true)
        {
            TowardsToCat();

        }

    }

    private void PlayerMovement()
    {
        Vector2 move = Vector2.zero;
        _currentSpeed = baseSpeed;

        if (Keyboard.current.shiftKey.isPressed)
        {
            _currentSpeed = baseSpeed * shiftSpeed;
        }

        if (Keyboard.current.dKey.isPressed)
        {
            move += Vector2.right * _currentSpeed;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        if (Keyboard.current.aKey.isPressed)
        {
            move += Vector2.left * _currentSpeed;
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }

        _rb.linearVelocity = new Vector2(move.x * _currentSpeed, _rb.linearVelocity.y);

        if (Keyboard.current.spaceKey.isPressed && IsGrounded() && Time.time - lastJumpTime >= jumpCooldown)
        {
            
            _rb.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            lastJumpTime = Time.time;
            jumpAudio.PlayOneShot(jumpClip);
        }

        if (_rb.linearVelocity.y < 0) _rb.gravityScale = fallGravity;
        else if(_rb.linearVelocity.y >=0) _rb.gravityScale = jumpGravity;



    }

    private void TowardsToCat()
    {
            Vector2 FirstTargetLocation = new Vector2(0f, -.8f);
            Vector2 SecondTargetLocation = new Vector2(0f, 2.73f);


        if (isFirstLocation == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, FirstTargetLocation, baseSpeed * Time.deltaTime);


            if (Vector2.Distance(transform.position, FirstTargetLocation) < 0.01f)
            {
                isFirstLocation = true;
            }
        }

        else
        {
            transform.position = Vector2.MoveTowards(transform.position, SecondTargetLocation, baseSpeed * Time.deltaTime);
        }
        
    }

    bool IsGrounded()
    {
        return Physics2D.OverlapCircle(_jumpArea.position, _radius, groundLayer);
    }


    
}
