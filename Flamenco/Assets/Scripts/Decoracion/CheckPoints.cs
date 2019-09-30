using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoints : MonoBehaviour
{
    bool Check = false;
    float posX;
    float posY;
    public static Vector3 heroTransform;
    /// <summary>
    /// guarda la posicion del jugador despues de cierto punto en el manpa
    /// </summary>
    /// <param name="collision"></param>
    void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (!Check)
        {
            if (collision.gameObject.tag == "Player")
            {
                         
                Vida.RespawnN = Vida.RespawnN + 1;
             
                Debug.Log(Vida.RespawnN);
                Check = true;
            }
        }

    }
}
