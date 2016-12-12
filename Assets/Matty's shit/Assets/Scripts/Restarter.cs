using UnityEngine;
using System.Collections;

public class Restarter : MonoBehaviour
{

   
        private void OnTriggerEnter2D(Collider2D other)
        {
            if(other.tag == "Player")
            {
                other.transform.position = new Vector2(-424, 20);
            }
        }
    

}
