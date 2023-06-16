using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosedGlider : MonoBehaviour
{
    
    
    public GameObject[] Gliders;
    public int GliderIndex;
    public bool ChangeGlider;

    // Update is called once per frame
    void Update()
    {
        if(ChangeGlider)
        {
            ChooseGlider();
            ChangeGlider=false;
        }
    }

    void ChooseGlider()
    {
        foreach (GameObject Glider in Gliders)
        {
            Glider.SetActive(false);

        }
        Gliders[GliderIndex].SetActive(true);

    }
}
