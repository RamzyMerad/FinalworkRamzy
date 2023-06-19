using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectionManager : MonoBehaviour
{
    public GameObject wallPaper;
    public bool CanISetPaper=false;
    public GameObject video;
    public GameObject PreviousVideo;
    // Start is called before the first frame update
    void Start()
    {

        //set paper to false
        wallPaper.SetActive(false);

    }


    //when there is a collision
    private void OnCollisionEnter(Collision collided)
    {
        //if the collided object contains the name paper
        if(collided.gameObject.name.Contains("Paper") && CanISetPaper){

            //destroy the collided object
            Destroy(collided.gameObject);
            
            PreviousVideo.SetActive(false);
            video.SetActive(true);
            //set paper to true
            wallPaper.SetActive(true);
        }
    }
}
