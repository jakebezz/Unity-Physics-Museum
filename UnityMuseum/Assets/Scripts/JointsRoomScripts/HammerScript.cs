using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerScript : MonoBehaviour
{
    //The hammer object 
    public Rigidbody Hammer;
    //The balls spawned infront of the hammer
    public Rigidbody hitObject;
    //Spawn location of the ball
    public Transform spawnLocation;

    //Sets Hammer isKinematic to false so that it starts spinning, also spawns a clone of the ball everytime player presses E
    private void OnTriggerStay(Collider other)
    {
        Rigidbody objRigid;

        if(other.gameObject.tag == "Player" && Input.GetButtonDown("e"))
        {
            Hammer.isKinematic = false;
            objRigid = Instantiate(hitObject, spawnLocation.position, spawnLocation.rotation) as Rigidbody;
        }
    }
}
