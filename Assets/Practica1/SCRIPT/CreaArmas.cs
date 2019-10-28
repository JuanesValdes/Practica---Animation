using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaArmas : MonoBehaviour
{
    //crear jerarquia 
    public string Id;
    public string nombre;
    public int vidautil;
    public int daño;
    ArmasB armasB;


    // Start is called before the first frame update
    void Start()
    {
        //acceder a todos los datos de enemigo b (leer un compónente)
        armasB = FindObjectOfType<ArmasB>();
        //va a leer un sistema de busqueda
        BusquedaArmas(Id);

    }

    private void BusquedaArmas(string id)
    {
        //de la base de datos enemigo, leer objetos de la lista enemigo 
        for (int i=0; i<armasB.armitas.Count; i++)
        {
            if (id==armasB.armitas[i].nombre)
            {
                //si encuentras el dato de ese bloque, a la variable agregale el balor siguiente
                nombre = armasB.armitas[i].nombre;
                vidautil = armasB.armitas[i].vidautil;
                daño = armasB.armitas[i].daño;
            }
        }
    }
  

}
