using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBallScript : MonoBehaviour
{
    //Starting force of ball
    public float force = 10f;

    //Bowling ball object
    public GameObject bowlingBall;

    //Default position for the ball
    public Transform bowlingBallLocation;

    private GameObject player;

    private void OnTriggerStay(Collider other)
    { 
        if (other.gameObject.tag == "Player")
        {
            //Increase force by two everyframe while Fire1 is held down
            if (Input.GetButtonDown("Fire1"))
            {
                force += 4 * Time.deltaTime;
            }
            //When button is up, set the bowling ball kinematic to off and fire the ball where player is facing
            if (Input.GetButtonUp("Fire1"))
            {
                bowlingBall.GetComponent<Rigidbody>().isKinematic = false;
                bowlingBall.GetComponent<Rigidbody>().AddForce(player.transform.forward * force, ForceMode.Impulse);
            }
        }
    }

    void Start()
    {
        //Sets player to player
        player = GameObject.FindWithTag("Player");

        //Moves the ball to the starting postion
        bowlingBall.transform.position = new Vector3(bowlingBallLocation.position.x, bowlingBallLocation.position.y, bowlingBallLocation.position.z);
    }

    //Always checks if the "RespawnBowling" button has be pressed, if it has, move the ball to the starting location and set isKinematic to false so it doesnt move
    private void Update()
    {
        if(RespawnBowlingScript.respawnBall == true)
        {
            bowlingBall.GetComponent<Rigidbody>().isKinematic = true;
            bowlingBall.transform.position = new Vector3(bowlingBallLocation.position.x, bowlingBallLocation.position.y, bowlingBallLocation.position.z);
            RespawnBowlingScript.respawnBall = false;
        }
    }
}
