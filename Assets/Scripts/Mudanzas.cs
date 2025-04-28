using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mudanzas : MonoBehaviour
{
    string vehiculo;
    public int distancia;
    public int capacidad;
    public int horas;
    int precio;
    // Start is called before the first frame update
    void Start()
    {
        if (horas < 2)
        {
            Debug.Log("El minimo de horas para contratar el servicio es 2 hs");
            return;
        }
        if (capacidad < 100 || capacidad > 10000) {
            Debug.Log("esa capacidad no podemos transportarla");
            return;

        }  else if (capacidad < 2000)
        {
            Debug.Log("El vehiculo necesario para el transporte es el Utiliario");
        }
        else if (capacidad < 2000  || capacidad > 5000)
        {
            Debug.Log("El vehiculo necesario para el transporte es la PickUp");
        }
        else if (capacidad < 5000 || capacidad > 10000)
        {
            Debug.Log("El vehiculo necesario para el transporte es el Camion");
        }

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
