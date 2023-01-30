using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingPinsScripts : MonoBehaviour
{
    //Private variable for the single pin, this is the one that will be destroyed
    GameObject thisPin;

    //Sets thisPin to the pin on start
    private void Start()
    {
        thisPin = gameObject;
    }

    //Destroy pins if they collide with the bowling ball or other pins
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "BowlingBall" || collision.gameObject.tag == "BowlingPin")
        {
            //Destory pins after 3 seconds
            Invoke("DestoryPins", 3);
        }
    }

    //Only destory the pins hit
    void DestoryPins()
    {
        Destroy(thisPin);
        //Gain a point for each pin hit
        PointScript.points++;
    }
}
