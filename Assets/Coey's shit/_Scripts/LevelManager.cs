using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

    public GameObject currentCheckpoint;
    private Player player;


    void Start()
    {
        player = FindObjectOfType<Player>();
    }



    public void RespawnPlayer()
    {
        Debug.Log("Player Respawn");
        player.transform.position = currentCheckpoint.transform.position;
    }

}
