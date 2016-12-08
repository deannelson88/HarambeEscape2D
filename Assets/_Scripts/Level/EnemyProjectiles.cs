using UnityEngine;
using System.Collections;

public class EnemyProjectiles : MonoBehaviour {

    public float projectileSpeed;

    public PlayerController player;

    public GameObject impactEffect;

    public int damageToGive;

    //

    void Start()
    {
        player = FindObjectOfType<PlayerController>();

        if (player.transform.position.x < transform.position.x)
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
        if (other.tag == "Player")
        {
            //Instantiate(enemyDeathEffect, other.transform.position, other.transform.rotation);
            //Destroy(other.gameObject);
            //ScoreManager.AddPoints(pointsForKill);

            PlayerHealthManager.HurtPlayer(damageToGive);
        }

        Instantiate(impactEffect, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}
