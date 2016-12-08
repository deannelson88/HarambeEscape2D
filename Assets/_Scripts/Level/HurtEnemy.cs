using UnityEngine;
using System.Collections;

public class HurtEnemy : MonoBehaviour {

    public int damageToGive;

    public float bounceOnEnemy;

    private Rigidbody2D myRigidBody2d;

    //

    void Start()
    {
        myRigidBody2d = transform.parent.GetComponent<Rigidbody2D>();
    }

    //

    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.tag == "enemy")
        {
            other.GetComponent<EnemyHealthManager>().GiveDamage(damageToGive);
            myRigidBody2d.velocity = new Vector2(myRigidBody2d.velocity.x, bounceOnEnemy);
        }
        
    }
}
