using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPoolBall : MonoBehaviour
{
    //If the ball collides with one of the holes, destory that ball
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "PoolHole")
        {
            Destroy(gameObject);
            //Increase players points
            PointScript.points++;
        }
    }
}
