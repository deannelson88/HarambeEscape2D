using UnityEngine;
using System.Collections;

public class Lives : MonoBehaviour {

    int lives = 3;
    public GUIText livesText;
    bool checkPoint = false;

	// Use this for initialization
	void Start () {
	
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
        if(other.tag == "Checkpoint")
        {
            checkPoint = true;
        }
    }

    void backToCheckpoint()
    {
        if ((lives == 0) && (checkPoint == false))
        {
            transform.position = new Vector2(-8, 1);
            lives = 3;
        }
        else if ((lives == 0) && (checkPoint == true))
        {
            transform.position = new Vector2(165, -53);
            lives = 3;
        }
    }

    public void UpdateLives()
    {
        livesText.text = "Lives: " + lives;
    }

}
