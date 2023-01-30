using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawnScript : MonoBehaviour
{
    //Four spawn positions
    public Transform spawnCoinPosOne;
    public Transform spawnCoinPosTwo;
    public Transform spawnCoinPosThree;
    public Transform spawnCoinPosFour;

    //Gets coin prefab 
    public Rigidbody Coin;

    private void OnTriggerStay(Collider other)
    {
        int rng = Random.Range(1, 5);
        Rigidbody coinRigidbody;

        //Each time player presses "Fire1" (mouse1) a coin will spawn at one of four positions.
        if (Input.GetKeyDown("e"))
        {
            if (rng == 1)
            {
                coinRigidbody = Instantiate(Coin, spawnCoinPosOne.position, spawnCoinPosOne.rotation) as Rigidbody;
            }
            else if (rng == 2)
            {
                coinRigidbody = Instantiate(Coin, spawnCoinPosTwo.position, spawnCoinPosTwo.rotation) as Rigidbody;
            }
            else if (rng == 3)
            {
                coinRigidbody = Instantiate(Coin, spawnCoinPosThree.position, spawnCoinPosThree.rotation) as Rigidbody;
            }
            else
            {
                coinRigidbody = Instantiate(Coin, spawnCoinPosFour.position, spawnCoinPosFour.rotation) as Rigidbody;
            }
        }
    }
}
