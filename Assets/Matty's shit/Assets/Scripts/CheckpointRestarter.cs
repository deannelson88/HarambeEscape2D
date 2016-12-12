using UnityEngine;
using System.Collections;

public class CheckpointRestarter : MonoBehaviour
{

 
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                other.transform.position = new Vector2(168, 94);
            }
        }
 

}
