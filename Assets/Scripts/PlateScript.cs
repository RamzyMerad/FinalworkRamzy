using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateScript : MonoBehaviour
{
    public bool isFull = false;

    public GameObject[] materialsObjects;
    public CraftManagerScript craftManagerScript;
    public GameObject MaterialVideo;
    public GameObject DesableVideo;
    public GameObject LastVideo;
    public bool PlayMaterialVideo;
    //selected material index
    public int selectedMaterialIndex;

    // Start is called before the first frame update
    void Start()
    {

        //materialsObjects are te bowl children
         // Get the number of child objects
        int childCount = transform.childCount;
        
        // Initialize the array
        materialsObjects = new GameObject[childCount];

        // Loop through each child and store them in the array
        for (int i = 0; i < childCount; i++)
        {
            materialsObjects[i] = transform.GetChild(i).gameObject;
            //set material to false
            materialsObjects[i].SetActive(false);

        }
    }

    //wehn there is a collision (check if it is a material)
    void OnCollisionEnter(Collision collision)
    {
        //if the collision is a material
        if (collision.gameObject.tag == "Material" && !isFull)
        {
            ResetPlate();
            collision.gameObject.transform.localPosition = new Vector3(0, 1, 0);
            //enable the selected material
            materialsObjects[selectedMaterialIndex].SetActive(true);
            isFull = true;
            craftManagerScript.FullPlate++;
        } else if(collision.gameObject.name == "wood Hammer")
        {
            craftManagerScript.craft=true;
            MaterialVideo.SetActive(true);
            DesableVideo.SetActive(false);

            if(selectedMaterialIndex==1)
            {
                Invoke("EndVideo",12f);
            }
            
        }
    }

    void EndVideo()
    {
        MaterialVideo.SetActive(false);
        LastVideo.SetActive(true);
        Invoke("DesactivateLastVideo",32f);
    }
    void DesactivateLastVideo()
    {
        MaterialVideo.SetActive(true);
        LastVideo.SetActive(false);
        
    }
    //reset the Plate
    public void ResetPlate()
    {
        //disable all materials
        for (int i = 0; i < materialsObjects.Length; i++)
        {
            materialsObjects[i].SetActive(false);
        }
    }
}
