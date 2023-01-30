using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrebuchetThrow : MonoBehaviour
{
    public Rigidbody weight;
    public GameObject throwObject;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Activates the weight to fall
            weight.isKinematic = false;
        }
        if (Input.GetButtonUp("Fire1"))
        {
            //Destroys the throw object's hinge so it gets thrown
            HingeJoint destroyHinge;
            destroyHinge = throwObject.GetComponent<HingeJoint>();
            Destroy(destroyHinge);
        }
    }
}
