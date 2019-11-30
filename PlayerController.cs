using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb2d;
    SpriteRenderer spRend;
    bool isGrounded;

	public int movSpeed;
	public int jumpPower;

    [SerializeField]
    Transform groundCheck;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        spRend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Fore2"))){
            isGrounded = true;
        } else{
            isGrounded = false;
        }

        if(Input.GetKey("d") || Input.GetKey("right")){
            rb2d.velocity = new Vector2(movSpeed,rb2d.velocity.y);
            animator.Play("MainCharacterWalk");
            spRend.flipX = false;
        }
        else if(Input.GetKey("a") || Input.GetKey("left")){
            rb2d.velocity = new Vector2(-movSpeed,rb2d.velocity.y);
            animator.Play("MainCharacterWalk");
            spRend.flipX = true;
        }
        else{
            animator.Play("MainCharacterIdle");
            rb2d.velocity = new Vector2(0,rb2d.velocity.y);
        }

        if(Input.GetKey("space") && isGrounded){
            rb2d.velocity = new Vector2(rb2d.velocity.x,jumpPower);
            animator.Play("MainCharacterJump");
        }
    }

}
