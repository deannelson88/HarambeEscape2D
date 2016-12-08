using UnityEngine;
using System.Collections;

public class EnemyPatrol : MonoBehaviour {

    public float moveSpeed;
    public bool moveRight;

    public Transform wallCheck;
    public float wallCheckRadius;
    public LayerMask whatIsWall;
    private bool hittingWall;

    private bool atEdge;
    public Transform edgeCheck;

    //private bool seePlayer;
    //public Transform playerCheck;

    //	
	
	void Update ()
    {

        hittingWall = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, whatIsWall);

        atEdge = Physics2D.OverlapCircle(edgeCheck.position, wallCheckRadius, whatIsWall);

      //  seePlayer = Physics2D.OverlapCircle(playerCheck.position, wallCheckRadius, whatIsWall);

        //if (seePlayer)
        //{
        //    moveSpeed = 5;
        //}
        //else
        //{
        //    moveSpeed = 1.5f;
        //}


        if (hittingWall || !atEdge)
            moveRight = !moveRight;



        if(moveRight)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);

            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
      
	
	}
}
