using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftManagerScript : MonoBehaviour
{
    
     public PlateScript[] plateScript;
     public GameObject Glider;
     public GameObject Plates;
     public GameObject CraftEffect;
     public AudioSource CraftAudio;
     public bool ActiveOnce=true;
     public bool AllPlatesAreFull;
     public int FullPlate=0;
     public bool craft=false;
     public GameObject Video;
     public GameObject[] VideosToStop;
     public bool CanIShowVideo;

    
     void Update()
     {
        
        //check if every plate is full
        if(ActiveOnce && FullPlate == 7 && craft)
        {
            ActiveOnce=false;
            CraftGlider();
        }
         if(FullPlate == 7)
         {
            PlayVideo();
         }

     }
    
   void PlayVideo()
    {
        if(CanIShowVideo)
        {
            foreach(GameObject VideoToStop in VideosToStop)
            {
                VideoToStop.SetActive(false);
            }
            CanIShowVideo=false;
            Video.SetActive(true);
            Invoke("DesableVideo",8f);
        }
    }

    void DesableVideo()
    {
        Video.SetActive(false);
    }

     public void CraftGlider()
     {
        Plates.SetActive(false);
        CraftEffect.SetActive(true);
        Glider.SetActive(true);
        CraftAudio.Play();
     }
  }
     
