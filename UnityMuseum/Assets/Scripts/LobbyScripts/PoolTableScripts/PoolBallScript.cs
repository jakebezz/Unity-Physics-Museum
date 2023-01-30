using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolBallScript : MonoBehaviour
{
    //Variables
    public float forceAmount = 300f;
    public Rigidbody PoolBall;
    private GameObject player;

    //Adds force to the ball in the direction the player is facing 
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetButtonDown("Fire1"))
            {
                PoolBall.AddForce(player.transform.forward * forceAmount, ForceMode.Impulse);
            }
        }
    }

    //Sets player game object to player
    private void Start()
    {
        player = GameObject.FindWithTag("Player");
    }
}

