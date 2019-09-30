using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalFight : MonoBehaviour
{  
   /// <summary>
   /// Camara del jugador normal
   /// </summary>
    public GameObject Camera;
    /// <summary>
    /// Camara del boss
    /// </summary>
    public GameObject cameraBoss;
    /// <summary>
    /// Camara idle
    /// </summary>
    public GameObject camaraIdle;
    /// <summary>
    /// regula las acciones del jefe
    /// </summary>
    public static bool iniciaFinal;

    /// <summary>
    /// se asegura de que el player este en la zona del jefe e inicie los patrones del jefe y su musica
    /// </summary>
    /// <param name="collision"></param>
    /// 

    private void Awake()
    {
        iniciaFinal = false;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            cameraBoss.SetActive(true);
            iniciaFinal = true;
            
        }
      
    }
    /// <summary>
    /// se asegura de que el player este fuera de la zona del jefe para cambiar el valor del bool y  detener los patrones del jefe 
    /// </summary>
    /// <param name="collision"></param>
    /// 
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            iniciaFinal = false;
        }
    }

}
