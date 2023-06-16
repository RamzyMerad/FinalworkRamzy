using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialScript : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
    //when the material Y position is less than -50 set his position to 0
     if (gameObject.transform.position.y < -10)
     {
       gameObject.transform.localPosition = new Vector3(0, 3, 0);
     }
    }
}
