using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialsManager : MonoBehaviour
{
   //Plate script (the script that is attached to the Plate)
    public PlateScript[] plateScript;
   public GameObject[] Materials;
    public CraftManagerScript craftManagerScript;
    public GameObject[] Gliders;
    public bool CanIShowVideo;
    public GameObject Video;
    public GameObject[] VideosToStop;
    public GameObject[] MaterialsVideos;
    // Start is called before the first frame update
    void Start()
    {
        ResetMaterial();
    }

    public void ResetMaterial()
    {
        
        foreach(GameObject Material in Materials)
        {
            Material.SetActive(false);
        }
        foreach(GameObject Glider in Gliders)
        {
            Glider.SetActive(false);
        }
        foreach(GameObject MaterialVideo in MaterialsVideos)
        {
            MaterialVideo.SetActive(false);
        }
        craftManagerScript.FullPlate=0;
    }
    public void MaterialOne()
    {
        ResetMaterial();
        PlayVideo();
        Gliders[0].SetActive(true);
        MaterialsVideos[0].SetActive(true);
        Materials[0].SetActive(true);
        //set every selectedMaterialIndex to 0
        for (int i = 0; i < plateScript.Length; i++)
        {
            plateScript[i].selectedMaterialIndex = 0;
            plateScript[i].isFull=false;
            plateScript[i].ResetPlate();
        }
        
    }
    public void MaterialTwo()
    {
        ResetMaterial();
        PlayVideo();
        Gliders[1].SetActive(true);
        MaterialsVideos[1].SetActive(true);
        Materials[1].SetActive(true);
        //set every selectedMaterialIndex to 0
        for (int i = 0; i < plateScript.Length; i++)
        {
            plateScript[i].selectedMaterialIndex = 1;
            plateScript[i].isFull=false;
            plateScript[i].ResetPlate();
        }
    }
    public void MaterialThree()
    {
        ResetMaterial();
        PlayVideo();
        Gliders[2].SetActive(true);
        MaterialsVideos[2].SetActive(true);
        Materials[2].SetActive(true);
        //set every selectedMaterialIndex to 0
        for (int i = 0; i < plateScript.Length; i++)
        {
            plateScript[i].selectedMaterialIndex = 2;
            plateScript[i].isFull=false;
            plateScript[i].ResetPlate();
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

}
