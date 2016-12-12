using UnityEngine;
using System.Collections;

public class Lives : MonoBehaviour {

    int lives = 3;
    public GUIText livesText;

    public LevelManager levelManager;
    

    // Use this for initialization
    void Start () {
        levelManager = FindObjectOfType<LevelManager>();
    }
	
	// Update is called once per frame
	void Update () {
        backToCheckpoint();
        UpdateLives();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            lives--;
        }
        
    }

    void backToCheckpoint()
    {
        if (lives <= 0)
        {
            levelManager.RespawnPlayer(); ;
            lives = 3;
        }
        
    }

    public void UpdateLives()
    {
        livesText.text = "Lives: " + lives;
    }

}
