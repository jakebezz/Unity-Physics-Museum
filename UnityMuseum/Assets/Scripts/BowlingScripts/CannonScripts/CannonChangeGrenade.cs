using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonChangeGrenade : MonoBehaviour
{
    public Material newMaterial;
    public GameObject PhysicObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CannonBall")
        {
            CannonShoot.GrenadeBall = true;
            PhysicObject.GetComponent<Renderer>().material = newMaterial;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        CannonShoot.GrenadeBall = false;
    }
}
