using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportationSystem : MonoBehaviour
{
   // Array of GameObjects to store teleportation points
    public GameObject[] teleportationPoints;
    public GameObject VrPlayer;

    // Function to teleport the player to the first point
    public void TeleportToPoint1()
    {
        if (teleportationPoints.Length > 0)
        {
            VrPlayer.transform.position = teleportationPoints[0].transform.position;
        }
    }

    // Function to teleport the player to the second point
    public void TeleportToPoint2()
    {
        if (teleportationPoints.Length > 1)
        {
            VrPlayer.transform.position = teleportationPoints[1].transform.position;
        }
    }

    // Function to teleport the player to the third point
    public void TeleportToPoint3()
    {
        if (teleportationPoints.Length > 2)
        {
            VrPlayer.transform.position = teleportationPoints[2].transform.position;
        }
    }
    public void TeleportToPoint4()
    {
        if (teleportationPoints.Length > 2)
        {
            VrPlayer.transform.position = teleportationPoints[3].transform.position;
        }
    }
    public void TeleportToPoint5()
    {
        if (teleportationPoints.Length > 2)
        {
            VrPlayer.transform.position = teleportationPoints[4].transform.position;
        }
    }
}
