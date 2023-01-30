using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatapultScript : MonoBehaviour
{
    //Catapult neck
    public Rigidbody catapultNeck;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && Input.GetButtonDown("Fire1"))
        {
            catapultNeck.isKinematic = false;
        }
    }
}
