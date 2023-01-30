using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollKinematicScript : MonoBehaviour
{
    //Variables for kinematic and gravity
    public Rigidbody[] ragdollParts;
    public GameObject fullRagdoll;

    Collider thisBallRigid;

    //Sets the ragdoll to kinematic so it doesnt move until hit by the ball
    void Start()
    {
        for (int i = 0; i < ragdollParts.Length; i++)
        {
            ragdollParts[i].isKinematic = true;
            ragdollParts[i].useGravity = false;
        }
    }

    //Sets the ragdoll kinematic to false so it can be hit by the ball
    private void OnTriggerEnter(Collider ballRigid)
    {
        thisBallRigid = ballRigid;
        if (ballRigid.tag == "ThrowBall")
        {
            PointScript.points++;
            for (int i = 0; i < ragdollParts.Length; i++)
            {
                ragdollParts[i].isKinematic = false;
                ragdollParts[i].useGravity = true;
            }

            //Destroys ragdoll and ball after a 3 second delay
            Invoke("DestroyRagBall", 3.0f);
        }
    }

    void DestroyRagBall()
    {
        Destroy(fullRagdoll);
        Destroy(thisBallRigid);
        //Sets canSpawn to true so a new ragdoll will be spawned
        SpawnRagdoll.canSpawn = true;
    }
}
