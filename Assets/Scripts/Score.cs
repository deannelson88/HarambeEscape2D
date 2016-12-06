using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

    public GUIText scoreText;
    private int score;
    

	// Use this for initialization
	void Start () {
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        UpdateScore();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PickUp")
        {
            score += 10;
        }

    }

    public void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }
}
