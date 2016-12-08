using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {


    public LevelManager levelManager;

    //

    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }

    //

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            levelManager.currenctCheckpoint = gameObject;
            Debug.Log("Checkpoint Activated " + transform.position);
        }
    }
}
