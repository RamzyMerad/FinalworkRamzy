using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractieInventor : MonoBehaviour
{
    public GameObject player;
    public GameObject[] distanceObjects;
    public GameObject[] videos;
    public int positionObjectIndex = 0;
    public bool canICheck = true;
    public int FirstVideoTime;
    public int SecondVideoTime;
    public int DesableLastVideo;

    public float distance = 0;


    // Start is called before the first frame update
    void Start()
    {

        //get the player object, get it by tag
        player = GameObject.FindGameObjectWithTag("MainCamera");


    }

    // Update is called once per frame
    void Update()
    {

        //check position between player and object

        if(positionObjectIndex<2)
        {
            distance = Vector3.Distance(player.transform.position, distanceObjects[positionObjectIndex].transform.position);
        }
         

        //when we can check and the distance is less than 1
        if (canICheck && distance < 3)
        {
            //we can't check anymore
            canICheck = false;

            //play video
            playVideo();
        }


    }

    void playVideo()
    {
        for(int i = 0; i < videos.Length; i++)
        {
            videos[i].SetActive(false);
        }
        //play video
        print("play video"+ positionObjectIndex);
        videos[positionObjectIndex].SetActive(true);

        if(positionObjectIndex == 1)
        {
            positionObjectIndex++;
            //set canICheck to true after 20 seconds
            Invoke("playVideo2", SecondVideoTime);
        }

        if(positionObjectIndex == 0)
        {
            positionObjectIndex++;
            //set canICheck to true after 13 seconds
            Invoke("setCanICheckToTrue", FirstVideoTime);
        }

        
    }

    void setCanICheckToTrue()
    {

        canICheck = true;
    }
    public void playVideo2()
    {
        //set all videos to false
         for(int i = 0; i < videos.Length; i++)
        {
            videos[i].SetActive(false);
        }

        //play video
        print("play video" + positionObjectIndex);
        videos[positionObjectIndex].SetActive(true);
        Invoke("DesableVideo", DesableLastVideo);
    }
    public void DesableVideo()
    {
        videos[2].SetActive(false);
    }
}
