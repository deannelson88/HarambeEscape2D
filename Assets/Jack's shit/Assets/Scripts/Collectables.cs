﻿using UnityEngine;
using System.Collections;

public class Collectables : MonoBehaviour {

   
  
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
        }
        
    }

    

}