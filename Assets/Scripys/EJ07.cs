﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ07 : MonoBehaviour
{
    //    Realizá un programa que al ingresar por Inspector tres números enteros num1, num2 y
    //num3, muestre el valor del mayor de todos.
    //En caso de igualdad entre los tres imprimir &quot; Los números son iguales&quot;. Test1: num1 =
    //12, num2 = 4, num3= 7. Resultado esperado: El mayor número es num1 Test2: num1

    //= 2, num2 = 65, num3= 8. Resultado esperado: El mayor número es num2
    public int num1;
    public int num2;
    public int num3;
    // Start is called before the first frame update
    void Start()
    {
        if(num1 > num2 && num2 > num3)
        {
            Debug.Log(num1);
        } 
        else if (num2 > num3 && num3 > num1)
        {
            Debug.Log(num2);
        }
        else if (num3 > num2 && num2 > num1)
        {
            Debug.Log(num3);
        }
        else if(num1 == num2 && num2 == num3)
        {
            Debug.Log("Los numeros son iguales");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
