using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBallCollision : MonoBehaviour
{
    //Destorys the ball on collision and gain a point
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ThrowBall")
        {
            Destroy(collision.gameObject);
            PointScript.points++;
        }
    }
}
