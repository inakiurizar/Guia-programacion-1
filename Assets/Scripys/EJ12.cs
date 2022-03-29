using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ12 : MonoBehaviour
{
    //    En un casino de juegos se desea mostrar los mensajes respectivos por el puntaje
    //obtenido en el lanzamiento de tres dados de un cliente, de acuerdo a los siguientes
    //resultados:
    //• Si los tres dados son seis, mostrar el mensaje “Excelente”
    //• Si dos dados son seis, mostrar el mensaje “Muy bien”
    //• Si un dado es seis, mostrar el mensaje “Regular”
    //• Si ningún dado se obtiene seis, mostrar el mensaje “Insuficiente”

    public int dado1;
    public int dado2;
    public int dado3;
    int cantSeis = 0;
     
    // Start is called before the first frame update
    void Start()
    {
      if(dado1 == 6)
        {
            cantSeis++;
        }
      if (dado2 == 6)
        {
            cantSeis++;
        }
      if (dado3 == 6)
        {
            cantSeis++;
        }

      switch(cantSeis)
        {
            case 0:
                Debug.Log("Insuficiente");
                break;
            case 1:
                Debug.Log("Regular");
                break;
            case 2:
                Debug.Log("Muy bien");
                break;
            case 3:
                Debug.Log("Excelente");
                break;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
