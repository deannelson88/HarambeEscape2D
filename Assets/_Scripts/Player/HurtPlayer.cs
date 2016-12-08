using UnityEngine;
using System.Collections;

public class HurtPlayer : MonoBehaviour {


    public int damageToGive;

    //

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            PlayerHealthManager.HurtPlayer(damageToGive);
            other.GetComponent<AudioSource>().Play();

            var player = other.GetComponent<PlayerController>();
            player.knockbackCount = player.knockbackLength;

            if(other.transform.position.x < transform.position.x)
            {
                player.knockFromRight = true;
            }
            else
            {
                player.knockFromRight = false;
            }
        }
    }
}
