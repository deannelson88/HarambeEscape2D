using UnityEngine;
using System.Collections;

public class PlatformDisappear : MonoBehaviour {

    private float wait = 0.3f;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
           Destroy(gameObject, wait);
        }

    }
}
