/*using UnityEngine;
using System.Collections;

public class AudioStop : MonoBehaviour
{

    public AudioClip BackgroundTrack;    // Add your Audi Clip Here;
    bool playMusic = true;               // This Will Configure the  AudioSource Component; 
                                         // MAke Sure You added AudioSouce to death Zone;
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = true;
        GetComponent<AudioSource>().clip = BackgroundTrack;
    }
    
    void Update()
    {
        StopSound();
    }

    void OnCollisionEnter2D(Collider2D other)  //Plays Sound Whenever collision detected
    {
        if (other.tag == "AudioStop")
        {
            playMusic = false;
        }
    }

    void StopSound()
    {
        if(playMusic == false)
        {
            GetComponent<AudioSource>().Stop();
        }
    }
    

        // Make sure that deathzone has a collider, box, or mesh.. ect..,
        // Make sure to turn "off" collider trigger for your deathzone Area;
        // Make sure That anything that collides into deathzone, is rigidbody;
}
*/