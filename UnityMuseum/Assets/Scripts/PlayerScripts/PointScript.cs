using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointScript : MonoBehaviour
{
    //Class with a static points int, also prints it to the UI Canvas
    public Text pointsText;
    public static int points = 0;
    void Update()
    {
        pointsText.text = points.ToString();
    }
}
