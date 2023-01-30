using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGrenade : MonoBehaviour
{
    //Basic script for spawning a grenade prefab infront of player
    public GameObject Grenade;

    public Transform SpawnLocation;
    void Update()
    {
        if(Input.GetKeyDown("g"))
        {
            Instantiate(Grenade, SpawnLocation.position, SpawnLocation.rotation);
        }
    }
}
