using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolBallEntraceScript : MonoBehaviour
{
    //Entrance prefab and location
    public GameObject entrance;
    public Transform entranceLocation;
    //Clone of entrance
    GameObject clone;
    //Bool to stop another entrance to spawn if player leaves the trigger box without pressing E beforehand
    bool alreadySpawned;
    //Destroies object when player presses E
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown("e"))
        {
            alreadySpawned = false;
            Destroy(clone);
        }
    }
    //Spawns a clone when player leaves the trigger box
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player" && alreadySpawned == false)
        {
            alreadySpawned = true;
            clone = Instantiate(entrance, entranceLocation.position, entranceLocation.rotation) as GameObject;
        }
    }

    //Create the entrance clone when game starts
    private void Start()
    {
        alreadySpawned = true;
        clone = Instantiate(entrance, entranceLocation.position, entranceLocation.rotation) as GameObject;
    }
}
