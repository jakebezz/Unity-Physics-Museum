using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTargetCube : MonoBehaviour
{
    //Destroy cube and adds points on collision
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "TargetCube")
        {
            Destroy(collision.gameObject, 3);
            PointScript.points++;
        }
    }
}
