using UnityEngine;
using System.Collections;

public class ProjectileController : MonoBehaviour {

    public float projectileSpeed;

    public PlayerController player;

    public GameObject enemyDeathEffect;
    public GameObject impactEffect;

    public int pointsForKill;

    public int damageToGive;

    //

    void Start()
    {
        player = FindObjectOfType<PlayerController>();

        if(player.transform.localScale.x < 0)
        {
            projectileSpeed = -projectileSpeed;
        }
    }

    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(projectileSpeed, GetComponent<Rigidbody2D>().velocity.y);
    }

    //

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "enemy")
        {
            //Instantiate(enemyDeathEffect, other.transform.position, other.transform.rotation);
            //Destroy(other.gameObject);
            //ScoreManager.AddPoints(pointsForKill);

            other.GetComponent<EnemyHealthManager>().GiveDamage(damageToGive);
        }

        Instantiate(impactEffect, transform.position, transform.rotation);

        Destroy(gameObject); 
    }


}
