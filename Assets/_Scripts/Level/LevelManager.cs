using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

    public GameObject currenctCheckpoint;

    private PlayerController player;
    public float respawnDelay;
    public int pointPenaltyOnDeath;
    private float gravityStore;

    public GameObject deathParticle;
    public GameObject respawnParticle;

    public PlayerHealthManager healthManager;

    private CameraController camera;


    //

	void Start () {
        player = FindObjectOfType<PlayerController>();

        healthManager = FindObjectOfType<PlayerHealthManager>();

        camera = FindObjectOfType<CameraController>();
	}

    //

    public void RespawnPlayer()
    {
        StartCoroutine("RespawnPlayerCo");
    }

    //

    public IEnumerator RespawnPlayerCo()
    {

        Instantiate(deathParticle, player.transform.position, player.transform.rotation);

        player.enabled = false;
        player.GetComponent<Renderer>().enabled = false;

        camera.isFollowing = false;
        player.transform.parent = null;

        player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        ScoreManager.AddPoints(-pointPenaltyOnDeath);

        Debug.Log("Player Respawn");
        yield return new WaitForSeconds(respawnDelay);
        player.transform.position = currenctCheckpoint.transform.position;

        healthManager.FullHealth();
        healthManager.isDead = false;

        player.enabled = true;
        player.GetComponent<Renderer>().enabled = true;

        camera.isFollowing = true;

        Instantiate(respawnParticle, currenctCheckpoint.transform.position, currenctCheckpoint.transform.rotation);
        
        
    }
}
