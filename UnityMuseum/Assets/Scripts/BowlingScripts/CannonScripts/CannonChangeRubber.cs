using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonChangeRubber : MonoBehaviour
{
    public PhysicMaterial physicMaterial;
    public Material newMaterial;
    public GameObject PhysicObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CannonBall")
        {
            CannonShoot.RubberBall = true;
            PhysicObject.GetComponent<Renderer>().material = newMaterial;
            PhysicObject.GetComponent<Collider>().material = physicMaterial;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        CannonShoot.RubberBall = false;
    }
}
