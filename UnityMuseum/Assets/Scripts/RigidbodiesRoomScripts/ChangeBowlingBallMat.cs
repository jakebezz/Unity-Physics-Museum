using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBowlingBallMat : MonoBehaviour
{
    //Variables for changing lane colour
    public Material newMaterial;
    public GameObject bowlingLane;

    //Variables for changing bowling ball physics material
    public GameObject bowlingBall;
    public PhysicMaterial physicMaterial;

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player" && Input.GetKeyDown("e"))
        {
            //Sets the objects to the material
            bowlingLane.GetComponent<Renderer>().material = newMaterial;
            bowlingLane.GetComponent<Collider>().material = physicMaterial;
            bowlingBall.GetComponent<Collider>().material = physicMaterial;
        }
    }
}
