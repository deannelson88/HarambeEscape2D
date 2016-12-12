using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    public LayerMask enemyMask;
    Rigidbody2D myBody;
    Transform myTrans;
    float myWidth;
    float myHeight;
    public float speed = 1;

	// Use this for initialization
	void Start () {

        myTrans = this.transform;
        myBody = this.GetComponent<Rigidbody2D>();
        SpriteRenderer mySprite = this.GetComponent<SpriteRenderer>();
        myWidth = mySprite.bounds.extents.x;
        myHeight = (mySprite.bounds.extents.y) - 0.2f;
    }
	
	// Update is called once per frame
	void FixedUpdate () {

        //Check to see if theres ground infront of us before moving forward
        Vector2 lineCastPos = myTrans.position.toVector2() - myTrans.right.toVector2() * myWidth + Vector2.down * myHeight;
        Debug.DrawLine(lineCastPos, lineCastPos + Vector2.down);
        bool isGround = Physics2D.Linecast(lineCastPos, lineCastPos + Vector2.down, enemyMask);
        Debug.DrawLine(lineCastPos, lineCastPos - myTrans.right.toVector2() * .5f);
        bool isBlocked = Physics2D.Linecast(lineCastPos, lineCastPos - myTrans.right.toVector2() * 0.00f, enemyMask);

        //if theres no ground turn around or if blocked
        if (!isGround || isBlocked)
        {
            Vector3 currentRot = myTrans.eulerAngles;
            currentRot.y += 180;
            myTrans.eulerAngles = currentRot;
        }

        //Always move forward
        Vector2 myVel = myBody.velocity;
        myVel.x = -myTrans.right.x * speed;
        myBody.velocity = myVel;

	}
}
