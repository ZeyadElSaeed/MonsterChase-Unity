using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveForce = 5;
    [SerializeField]
    private float jumpForce = 10;

    private float movementX;
    private string WALK_ANIMATION = "Walk";
    private string GROUND_TAG = "Ground";
    private string ENEMY_TAG = "Enemy";
    private bool isGrounded;

    private Rigidbody2D body;
    private Animator anim;
    private SpriteRenderer sp;

   
     private void Awake()
    {
        isGrounded = true;
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sp = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerJump();
        AnimatePlayer();
        PlayerMoveKeyboard();
    }

    private void FixedUpdate()
    {
        
    }

    private void PlayerMoveKeyboard() {
        movementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementX, 0f, 0f) * moveForce * Time.deltaTime;
    }

    private void AnimatePlayer() {
        if (movementX > 0)
        {
            anim.SetBool(WALK_ANIMATION, true);
            sp.flipX = false;
        }
        else if (movementX < 0)
        {
            anim.SetBool(WALK_ANIMATION, true);
            sp.flipX = true;
        }
        else {
            anim.SetBool(WALK_ANIMATION, false);
        }
    }


    private void PlayerJump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isGrounded = false;
            body.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(GROUND_TAG))
        {
            isGrounded = true;
        }

        if (collision.gameObject.CompareTag(ENEMY_TAG))
        {
            Destroy(gameObject);
        }
    }


}
