using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLightController : MonoBehaviour
{
   public Light spotlight;
    public float[] outerSpotAngles = { 30, 45, 60 };
    public GameObject[] videos;
    void Start()
    {
        if (spotlight == null)
        {
            spotlight = GetComponent<Light>();
        }
        resetLight();

    }

    public void resetLight()
    {
        spotlight.spotAngle = 0f;
    }        
    public void LittleRange()
    {
        spotlight.spotAngle = outerSpotAngles[0];
        PlayRightVideo(0);
    }
    public void MidRange()
    {
        spotlight.spotAngle = outerSpotAngles[1];
        PlayRightVideo(2);
    }
    public void BigRange()
    {
        spotlight.spotAngle = outerSpotAngles[2];
        PlayRightVideo(1);
    }
    public void PlayRightVideo(int videoIndex)
    {
        //set all videos to false
        foreach(GameObject video in videos){
            video.SetActive(false);
        }

        videos[videoIndex].SetActive(true);
    }
}
