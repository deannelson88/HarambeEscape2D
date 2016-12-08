using UnityEngine;
using System.Collections;

public class ShootAtPlayer : MonoBehaviour {

    public float playerRange;

    public GameObject enemyPojectile;

    public PlayerController player;

    public Transform firePoint;

    public float timeBetweenShots;
    private float shotCounter;

    //

    void Start()
    {
        player = FindObjectOfType<PlayerController>();

        shotCounter = timeBetweenShots;
    }

    //

    void Update()
    {
        Debug.DrawLine(new Vector3(transform.position.x - playerRange, transform.position.y, transform.position.z), new Vector3(transform.position.x + playerRange, transform.position.y, transform.position.z));
        shotCounter -= Time.deltaTime;        

        if(transform.localScale.x < 0 && player.transform.position.x > transform.position.x && player.transform.position.x < transform.position.x + playerRange && shotCounter < 0)
        {
            Instantiate(enemyPojectile, firePoint.position, firePoint.rotation);
            shotCounter = timeBetweenShots;
        }



        if (transform.localScale.x > 0 && player.transform.position.x < transform.position.x && player.transform.position.x > transform.position.x - playerRange && shotCounter < 0)
        {
            Instantiate(enemyPojectile, firePoint.position, firePoint.rotation);
            shotCounter = timeBetweenShots;
        }

    }
}
