using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDestroy : MonoBehaviour
{
    //Destroys coin when colliding with the bottom of the coin machine and increse players points
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "DestroyCoin")
        {
            Destroy(gameObject);
            PointScript.points++;
        }
    }
}
