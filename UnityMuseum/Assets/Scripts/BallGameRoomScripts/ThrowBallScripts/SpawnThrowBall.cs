using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnThrowBall : MonoBehaviour
{
    //Location of where ball will spawn
    public Transform spawnLocation;
    //The ball
    public Rigidbody throwBall;

    public Rigidbody ballClone;

    //Spawns clone of the ball when player presses E at the button
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player" && Input.GetKeyDown("e"))
        {
            ballClone = Instantiate(throwBall, spawnLocation.position, spawnLocation.rotation) as Rigidbody;
        }
    }
}
