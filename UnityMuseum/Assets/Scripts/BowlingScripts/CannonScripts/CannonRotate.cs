using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonRotate : MonoBehaviour
{
    //How much the angle changes each input
    public float angle = 5f;
    //Object to be rotated
    public GameObject cannonBarrel;

    //Target variables
    public GameObject target;
    //Target location
    public Transform targetLocation;
    //Target clone object
    GameObject targetClone;

    //Spawns clone of target on start
    private void Start()
    {
        targetClone = Instantiate(target, targetLocation.position, targetLocation.rotation) as GameObject;
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(Input.GetKeyDown("r") && cannonBarrel.transform.rotation.eulerAngles.z >= 55.327f && cannonBarrel.transform.rotation.eulerAngles.z < 91.327f)
            {
                cannonBarrel.transform.Rotate(0, 0, -angle, Space.Self);
            }
            if(Input.GetKeyDown("f") && cannonBarrel.transform.rotation.eulerAngles.z <= 85.327f && cannonBarrel.transform.rotation.eulerAngles.z > 51.327f)
            {
                cannonBarrel.transform.Rotate(0, 0, angle, Space.Self);
            }
            if(Input.GetKeyDown("e"))
            {
                //Clone targets
                Destroy(targetClone);
                targetClone = Instantiate(target, targetLocation.position, targetLocation.rotation) as GameObject;
            }
        }
    }
}
