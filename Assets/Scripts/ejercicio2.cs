using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos 
//y un monto de dinero disponible.Comunicar si la suma de los mismos supera o no el monto de dinero disponible.
//Luego indicar cuánto dinero sobra o falta.

public class ejercicio2 : MonoBehaviour
{
    public int producto1;
    public int producto2;
    public int producto3;
    public int presupuesto;

    // Start is called before the first frame update
    void Start()
    {
        int preciototal = producto1 + producto2 + producto3;
        if (preciototal > presupuesto)
        {
            Debug.Log("El precio de los productos supera el presupuesto");
            int falta = preciototal -  presupuesto;
            Debug.Log("sobra " + falta);
        }
        else 
        {
            Debug.Log("El precio de los productos no supera el presupuesto");
            int sobra = presupuesto - preciototal;
            Debug.Log("falta " + sobra);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
