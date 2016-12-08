using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float jumpHeight;
    private float moveVelocity;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;

    private bool doubleJump;

    public Transform firePoint;
    public GameObject projectile;

    public float knockback;
    public float knockbackCount;
    public float knockbackLength;
    public bool knockFromRight;

    //

    void FixedUpdate()
    {

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround); 

    }
    
    //
	
	void Update ()
    {

        if(grounded)
        {
            doubleJump = false;
        }//Resets doubleJump



        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            Jump();
        } //Jump



        if (Input.GetKeyDown(KeyCode.Space) && !doubleJump && !grounded)
        {
            Jump();
            doubleJump = true;
        } //Double Jump



        moveVelocity = 0f;



        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveVelocity = moveSpeed;
        } //Move Right



        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveVelocity = -moveSpeed;
        } //Move Left

        if(GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }//Face Right
        else if (GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }//Face Left

        if (knockbackCount <= 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            if(knockFromRight)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(-knockback, knockback);
            }
            if(!knockFromRight)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(knockback, knockback);
            }
            knockbackCount -= Time.deltaTime;
        }



        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(projectile, firePoint.position, firePoint.rotation);
        }

    }

    //

    public void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
    }

    //

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.tag == "MovingPlatform")
        {
            transform.parent = other.transform;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.transform.tag == "MovingPlatform")
        {
            transform.parent = null;
        }
    }

}
