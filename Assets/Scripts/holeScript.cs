using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holeScript : MonoBehaviour
{
    public GameObject[] wholeCylinder; // Assign in the Inspector
    public GameObject[] fracturedCylinder; // Assign in the Inspector
    public GameObject[] otherWalls; // Assign other walls in the Inspector
    public GameObject[] positionReference;
    public GameObject spotlightControllerScript;//spotlightController script
    public GameObject ProjectionManagerScript; //projectionManager script
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object contains the name 'Hammer'
        if (collision.gameObject.name.Contains("Hammer"))
        {
            // Check which size hammer it is
            if (collision.gameObject.name.Contains("Big"))
            {
                // Disable the other walls
                foreach (GameObject wall in otherWalls)
                {
                    wall.SetActive(false);
                }

                otherWalls[0].SetActive(true);
                //start the function Bigrange of the spotlight controller
                spotlightControllerScript.GetComponent<SpotLightController>().BigRange();


                //Start the function projection if its true, otherwise no
                ProjectionManagerScript.GetComponent<ProjectionManager>().CanISetPaper=false;

                // Disable the whole cylinder and enable the fractured cylinder
                wholeCylinder[0].SetActive(false);
                Instantiate(fracturedCylinder[0], positionReference[0].transform.position, positionReference[0].transform.rotation);

            }else if(collision.gameObject.name.Contains("Average"))
            {
                
            
            
                // Disable the other walls
                foreach (GameObject wall in otherWalls)
                {
                    wall.SetActive(false);
                }

                otherWalls[1].SetActive(true);
                //start the function Midrange of the spotlight controller
                spotlightControllerScript.GetComponent<SpotLightController>().MidRange();

                //Start the function projection if its true, otherwise no
                ProjectionManagerScript.GetComponent<ProjectionManager>().CanISetPaper=true;

                // Disable the whole cylinder and enable the fractured cylinder
                wholeCylinder[1].SetActive(false);
                Instantiate(fracturedCylinder[1], positionReference[1].transform.position, positionReference[1].transform.rotation);
            
        } else if(collision.gameObject.name.Contains("Little"))
        {
            
            // Disable the other walls
                foreach (GameObject wall in otherWalls)
                {
                    wall.SetActive(false);
                }

                otherWalls[2].SetActive(true);
                //start the function little range of the spotlight controller
                spotlightControllerScript.GetComponent<SpotLightController>().LittleRange();

                //Start the function projection if its true, otherwise no
                ProjectionManagerScript.GetComponent<ProjectionManager>().CanISetPaper=false;

                // Disable the whole cylinder and enable the fractured cylinder
                wholeCylinder[2].SetActive(false);
                Instantiate(fracturedCylinder[2], positionReference[2].transform.position, positionReference[2].transform.rotation);
        }
    }
}
    public void ResetWall()
    {
        foreach (GameObject cilinder in wholeCylinder)
                {
                    cilinder.SetActive(true);
                }
        //reset Light
         spotlightControllerScript.GetComponent<SpotLightController>().resetLight();

    }
}
