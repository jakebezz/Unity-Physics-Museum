using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeigeWeaponChange : MonoBehaviour
{
    //Seige weapon and target GameObjects
    public GameObject trebuchet;
    public GameObject catapult;
    public GameObject target;
    //Locations to place them
    public Transform trebuchetLocation;
    public Transform catapultLocation;
    public Transform targetLocation;
    //Current one spawned
    GameObject currentObject;
    GameObject clone;
    //Target clone object
    GameObject targetClone;


    private void Start()
    {
        //Trebuchet will be the deafult one spawned
        currentObject = trebuchet;
        clone = Instantiate(currentObject, trebuchetLocation.position, trebuchetLocation.rotation) as GameObject;
        targetClone = Instantiate(target, targetLocation.position, targetLocation.rotation) as GameObject;
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player" && Input.GetKeyDown("e"))
        {
            //Destory current seige weapon
            Destroy(clone);

            //Clone targets
            Destroy(targetClone);
            targetClone = Instantiate(target, targetLocation.position, targetLocation.rotation) as GameObject;

            //Changes currentObject based on which object is currently spawned
            if (currentObject == trebuchet)
            {
                //Sets currentObject to the new siege weapon
                currentObject = catapult;
                //Clones the object
                clone = Instantiate(currentObject, catapultLocation.position, catapultLocation.rotation) as GameObject;
            }
            else if(currentObject == catapult)
            {
                currentObject = trebuchet;
                clone = Instantiate(currentObject, trebuchetLocation.position, trebuchetLocation.rotation) as GameObject;
            }
        }
    }
}
