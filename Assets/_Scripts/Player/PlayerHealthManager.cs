using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealthManager : MonoBehaviour {

    public static int playerHealth;
    public int maxPlayerHealth;

    Text text;

    private LevelManager levelManager;

    public bool isDead;

    //

	void Start ()
    {
        text = GetComponent<Text>();
        playerHealth = maxPlayerHealth;

        levelManager = FindObjectOfType<LevelManager>();
    }
	
    //
	
	void Update ()
    {
	    if(playerHealth <= 0 && !isDead)
        {

            playerHealth = 0;
            levelManager.RespawnPlayer();

            isDead = true;
        }

        text.text = "" + playerHealth;

	}

    //

    public static void HurtPlayer(int damageToGive)
    {
        playerHealth -= damageToGive;
    }

    //

    public void FullHealth()
    {
        playerHealth = maxPlayerHealth;
    }

}
