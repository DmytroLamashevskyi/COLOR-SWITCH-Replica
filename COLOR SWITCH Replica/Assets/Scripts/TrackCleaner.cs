using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackCleaner : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        var player = collision.gameObject.GetComponent<Player>();
        if (player == null)
        {
            Destroy(collision.gameObject);
        }
        else
        {
            player.GameOver();
        }
    }
}
