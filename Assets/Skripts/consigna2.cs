using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Crear las variables necesarias para ingresar por Inspector
// el precio de 3 productos y un monto de dinero disponible. 
// Comunicar si la suma de los mismos supera o no el monto de dinero disponible. 
// Luego indicar cuánto dinero sobra o falta.

public class consigna2 : MonoBehaviour
{
    public float producto1;
    public float producto2;
    public float producto3;
    public float MontoDisponible;

    // Start is called before the first frame update
    void Start()
    {
        float SumaDeProductos = producto1 + producto2 + producto3;

        if (SumaDeProductos > MontoDisponible)
        {
            float faltante = SumaDeProductos - MontoDisponible;
            Debug.Log("La suma de los productos supera el monto disponible. Faltan $" + faltante);
        }

        if (SumaDeProductos < MontoDisponible)
        {
            float sobrante = MontoDisponible - SumaDeProductos;
            Debug.Log("La suma de los productos no supera el monto disponible. Sobran $" + sobrante);
        }

        else
        {
            Debug.Log("La suma de los productos es igual al monto disponible. No sobra ni falta dinero");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
