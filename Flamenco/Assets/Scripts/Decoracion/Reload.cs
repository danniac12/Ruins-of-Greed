using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour
{
   float posX;
   float posY;
    // Start is called before the first frame update
    void Start()
    {
        posX = PlayerPrefs.GetFloat("posX");
        posY = PlayerPrefs.GetFloat("posY");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
