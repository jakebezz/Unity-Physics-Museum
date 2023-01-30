using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPickThrow : MonoBehaviour
{
    //Variables for Picking up and Throwing Objects
    public Camera camera;

    //Different location based on the item picked up
    public Transform objectPos;
    public Transform throwBallPos;

    //The item picked up
    Rigidbody grabbedObj;

    //Floats for grab distance and throwing force
    public float maxGrabDistance = 10f;
    public float throwForce = 20f;
    public float ballThrowForce = 10f;
    //Used to make the object not lag when moving camera
    public float lerpSpeed = 10f;

    void Update()
    {
        //If an object is grabbed and checks that it doesn't have the NoPickUp tag
        if (grabbedObj && grabbedObj.tag != "NoPickUp")
        {
            //If it is a ThrowBall
            if (grabbedObj.tag == "ThrowBall")
            {
                //Moves object to position
                grabbedObj.MovePosition(Vector3.Lerp(grabbedObj.position, throwBallPos.transform.position, Time.deltaTime * lerpSpeed));

                //Increases force of the ball until let go
                if (Input.GetButton("Fire1"))
                {
                    ballThrowForce += 6 * Time.deltaTime;
                }
                //Fires the ball forward 
                if (Input.GetButtonUp("Fire1"))
                {
                    grabbedObj.isKinematic = false;
                    grabbedObj.AddForce(camera.transform.forward * ballThrowForce, ForceMode.VelocityChange);
                    //Sets grabbedObj to null so the game knows there is not an object in their hand
                    grabbedObj = null;
                }
            }
            else
            {
                grabbedObj.MovePosition(Vector3.Lerp(grabbedObj.position, objectPos.transform.position, Time.deltaTime * lerpSpeed));

                if (Input.GetButtonDown("Fire1"))
                {
                    grabbedObj.isKinematic = false;
                    grabbedObj.AddForce(camera.transform.forward * throwForce, ForceMode.VelocityChange);
                    grabbedObj = null;
                }
            }
        }

        //Picks up object
        if (Input.GetKeyDown("e"))
        {
            if (grabbedObj)
            {
                grabbedObj.isKinematic = false;
                grabbedObj = null;
            }
            else
            {
                RaycastHit hit;
                Ray ray = camera.ViewportPointToRay(new Vector3(0.5f, 0.5f));
                if (Physics.Raycast(ray, out hit, maxGrabDistance))
                {
                    //Sets object to kinematic 
                    grabbedObj = hit.collider.gameObject.GetComponent<Rigidbody>();
                    if (grabbedObj)
                    {
                        grabbedObj.isKinematic = true;
                    }
                }
            }
        }
    }
}
