using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInGlider : MonoBehaviour
{
     public GameObject glider;
     public GameObject player;
     public GameObject playerInsideGlider;
     public bool CheckPlayerinsideGlider;
     public PlaneController PlaneController;
    void Start()
     {
        PlaneController.enabled=false;
        CheckPlayerinsideGlider = !CheckPlayerinsideGlider;
        setPlayer();
     }
     public void setPlayer()
    {

        //if the player is inside the glider
        if (CheckPlayerinsideGlider)
        {
            //put the player outside the glider
            PutPlayerOutsideGlider();
        }
        else
        {
            //put the player inside the glider
            PutPlayerInGlider();
        
        }
    }
    //function to put the player incide the glider
    public void PutPlayerInGlider()
    {

        
        
        //spawn the glider in the position of the player (add 1 to the Y position))
        glider.SetActive(true);
        glider.transform.position = player.transform.position + new Vector3(0, 3, 0);

        //enable the plane controller
        PlaneController.enabled = true;

        //disable the player
        player.SetActive(false);
        
    }

    //function to put the player outside the glider
    public void PutPlayerOutsideGlider()
    {
         //disable the glider
        glider.SetActive(false);
        
        //enable the player and put it in the position of the glider (add 1 to the Y position))
        player.SetActive(true);
        player.transform.position = glider.transform.position + new Vector3(0, 3, 0);
        //enable the plane controller
        PlaneController.enabled = false;


    }
}
