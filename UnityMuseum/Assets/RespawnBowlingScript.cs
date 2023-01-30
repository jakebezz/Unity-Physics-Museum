using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnBowlingScript : MonoBehaviour
{
    //Respawn Location
    public Transform bowlingPinsLocation;
    //For respawning all the pins
    public GameObject bowlingPins;
    //Clone object
    GameObject pinClone;
    //Public static bool for moving the bowling ball to deafult location
    public static bool respawnBall;

    //Creates clones and sets respawnBall to false
    private void Start()
    {
        pinClone = Instantiate(bowlingPins, bowlingPinsLocation.position, bowlingPinsLocation.rotation) as GameObject;
        respawnBall = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player" && Input.GetKeyDown("e"))
        {
            //Set respawnBall to true so ball move to starting location
            respawnBall = true;
            //Destory all pins and clone them
            Destroy(pinClone);
            pinClone = Instantiate(bowlingPins, bowlingPinsLocation.position, bowlingPinsLocation.rotation) as GameObject;
        }
    }
}

