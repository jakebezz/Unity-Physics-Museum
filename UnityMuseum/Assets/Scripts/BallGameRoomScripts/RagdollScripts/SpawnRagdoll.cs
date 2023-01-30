using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRagdoll : MonoBehaviour
{
    public Transform spawnLoc;
    public GameObject ragdoll;
    public static bool canSpawn;

    private void Start()
    {
        canSpawn = true;
    }

    private void Update()
    {
        //Alwys checks if canSpawn is true so it will spawn a new ragdoll when the previous one was destroyed
        if (canSpawn == true)
        {
            CreateRagdoll();
        }
    }

    //Creates ragdoll gameobject
    public void CreateRagdoll()
    {
        GameObject ragObj;
        ragObj = Instantiate(ragdoll, spawnLoc.position, spawnLoc.rotation);
        //Sets canSpawn to false as a ragdoll has just been created
        canSpawn = false;
    }

}
