using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public PlayerController2D player;

    public bool isFollowing;

    public float xOffset;
    public float yOffset;

    //

    void Start()
    {
        player = FindObjectOfType<PlayerController2D>();

        isFollowing = true;
    }

    //

    void Update()
    {
        if(isFollowing)
        {
            transform.position = new Vector3(player.transform.position.x + xOffset, player.transform.position.y + yOffset, transform.position.z);
        }
    }
}
