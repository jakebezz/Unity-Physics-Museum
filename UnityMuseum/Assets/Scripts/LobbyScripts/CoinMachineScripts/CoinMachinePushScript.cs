using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMachinePushScript : MonoBehaviour
{
    //Speed the push obj will move
    private float speed = 2.0f;
    //How far the obj will move
    private float distance = 1.5f;

    //Used for the ThrowBall room targets
    public string direction = " ";

    //Start position of the obj
    private Vector3 startPosition;


    void Start()
    {
        //Sets the start position as the obj location
        startPosition = transform.position;
    }

    //Moves the obj every frame
    void Update()
    {
        Vector3 v = startPosition;

        //Direction changes based on input in the inspector
        if(direction == "left")
        {
            v.x += distance * Mathf.Sin(Time.time * speed);
            transform.position = v;
        }
        else if(direction == "right")
        {
            v.x -= distance * Mathf.Sin(Time.time * speed);
            transform.position = v;
        }
        else if(direction == "forward")
        {
            v.z += distance * Mathf.Sin(Time.time * speed);
            transform.position = v;
        }
        else if(direction == "back")
        {
            v.z -= distance * Mathf.Sin(Time.time * speed);
            transform.position = v;
        }
    }
}
