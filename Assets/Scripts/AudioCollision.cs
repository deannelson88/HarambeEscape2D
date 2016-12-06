using UnityEngine;
using System.Collections;

public class AudioCollision : MonoBehaviour
{
    public AudioClip SuspenseTrack;    // Add your Audi Clip Here;
                             // This Will Configure the  AudioSource Component; 
                             // MAke Sure You added AudioSouce to death Zone;
    void Update()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = SuspenseTrack;
    }

    void OnCollisionEnter2D()  //Plays Sound Whenever collision detected
    {
        GetComponent<AudioSource>().Play();
    }
    // Make sure that deathzone has a collider, box, or mesh.. ect..,
    // Make sure to turn "off" collider trigger for your deathzone Area;
    // Make sure That anything that collides into deathzone, is rigidbody;
}
