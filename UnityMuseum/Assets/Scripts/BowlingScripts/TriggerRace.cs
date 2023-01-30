using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRace : MonoBehaviour
{
    public Rigidbody BallOne;
    public Rigidbody BallTwo;
    public Rigidbody BallThree;
    public Rigidbody BallFour;
    public Rigidbody BallFive;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown("e") && other.gameObject.tag == "Player")
        {
            //Activates the balls to fall
            BallOne.isKinematic = false;
            BallTwo.isKinematic = false;
            BallThree.isKinematic = false;
            BallFour.isKinematic = false;
            BallFive.isKinematic = false;
        }
    }

}
