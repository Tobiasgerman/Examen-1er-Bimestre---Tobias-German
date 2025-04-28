using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mudanzas : MonoBehaviour
{
    string vehiculo;
    public int distancia;
    public int capacidad;
    public int horas;
    int precioutiliario = 3000;
    int precioPickUp = 4500;
    int precioCamion = 7000;

    // Start is called before the first frame update
    void Start()
    {
        if (distancia < 1)
        {
            Debug.Log("la distancia minima es 1km");
            return;
        }
        if (horas < 2)
        {
            Debug.Log("El minimo de horas para contratar el servicio es 2 hs");
            return;
        }
        if (capacidad < 100 || capacidad > 10000) {
            Debug.Log("esa capacidad no podemos transportarla");
            return;

        } else if (capacidad < 2000)
        {
            Debug.Log("El vehiculo necesario para el transporte es el Utiliario que tiene un costo de 3000$ por hora");
        }
        else if (capacidad < 2000 || capacidad > 5000)
        {
            Debug.Log("El vehiculo necesario para el transporte es el camion que tiene un costo de 7000$ por hora");
        }
        else if (capacidad < 5000 || capacidad > 10000)
        {
            Debug.Log("El vehiculo necesario para el transporte es la Pick Up que tiene un costo de 4500$ por hora");
        }
        if ( capacidad < 2000)
        {
            Debug.Log("el precio total por " + horas + "  horas ingresadas es =" + precioutiliario * horas);
        }
        else  if ( capacidad < 2000 || capacidad > 5000)
        {
            Debug.Log("el precio total por " + horas + " horas ingresadas es =" + precioCamion * horas);
           
        }
       else  if ( capacidad < 5000 || capacidad > 10000)
        {
            Debug.Log("el precio total por " + horas + " horas ingresadas es =" + precioPickUp * horas);
        }
        if (distancia > 50)
        {
            Debug.Log("Le cobraremos un extra debido a la cantidad de Km solicitada");
        }


        

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
