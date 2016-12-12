using UnityEngine;
using System;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class CheckpointRestart : MonoBehaviour
    {

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                transform.position = new Vector2(165, -53);
            }
        }

    }
}
