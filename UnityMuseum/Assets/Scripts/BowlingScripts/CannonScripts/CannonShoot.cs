using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShoot : MonoBehaviour
{
    public Transform posCannonBall;

    public Rigidbody IceCannonBall;
    public static bool IceBall = false;

    public Rigidbody RubberCannonBall;
    public static bool RubberBall = false;

    public Rigidbody MetalCannonBall;
    public static bool MetalBall = false;

    public Rigidbody GrenadeCannonBall;
    public static bool GrenadeBall = false;

    public Rigidbody StandardCannonBall;

    public float forceAmount = 300f;

    void OnTriggerStay()
    {
        Rigidbody Cannonrigidbody;
        if (Input.GetButtonDown("Fire1") && IceBall == true)
        {
            Cannonrigidbody = Instantiate(IceCannonBall, posCannonBall.position, posCannonBall.rotation) as Rigidbody;
            Cannonrigidbody.isKinematic = false;
            Cannonrigidbody.AddForce(posCannonBall.forward * forceAmount);
        }

        if (Input.GetButtonDown("Fire1") && RubberBall == true)
        {
            Cannonrigidbody = Instantiate(RubberCannonBall, posCannonBall.position, posCannonBall.rotation) as Rigidbody;
            Cannonrigidbody.isKinematic = false;
            Cannonrigidbody.AddForce(posCannonBall.forward * forceAmount);
        }

        if (Input.GetButtonDown("Fire1") && MetalBall == true)
        {
            Cannonrigidbody = Instantiate(MetalCannonBall, posCannonBall.position, posCannonBall.rotation) as Rigidbody;
            Cannonrigidbody.isKinematic = false;
            Cannonrigidbody.AddForce(posCannonBall.forward * forceAmount);
        }

        if (Input.GetButtonDown("Fire1") && GrenadeBall == true)
        {
            Cannonrigidbody = Instantiate(GrenadeCannonBall, posCannonBall.position, posCannonBall.rotation) as Rigidbody;
            Cannonrigidbody.isKinematic = false;
            Cannonrigidbody.AddForce(posCannonBall.forward * forceAmount);
        }

        if (Input.GetButtonDown("Fire1") && IceBall == false && RubberBall == false && MetalBall == false && GrenadeBall == false)
        {
            Cannonrigidbody = Instantiate(StandardCannonBall, posCannonBall.position, posCannonBall.rotation) as Rigidbody;
            Cannonrigidbody.isKinematic = false;
            Cannonrigidbody.AddForce(posCannonBall.forward * forceAmount);
        }
    }
}
