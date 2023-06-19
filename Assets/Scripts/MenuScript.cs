using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    
    public GameObject[] Menus;
    
    public void TeleportationMenu(){
    foreach (GameObject menu in Menus)
        {
            menu.SetActive(false);
        }
    Menus[1].SetActive(true);
    }

}
