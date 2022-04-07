using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Crea un programa que permita ingresar por Inspector 
// dos valores enteros y responda si son iguales o no lo son.

public class consigna1 : MonoBehaviour
{
    public int valor1;
    public int valor2;

    // Start is called before the first frame update
    void Start()
    {
        if (valor1 == valor2)
        {
            Debug.Log("Ambos valores enteros son iguales");
        }

        else
        {
            if (valor1 > valor2)
            {
                Debug.Log("Loas valores no son iguales. El valor1 es mayor al valor2");
            }

            else
            {
                Debug.Log("Los valores no son iguales. El valor2 es mayor al valor1");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
