using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crearenemigo : MonoBehaviour
{
    //crear jerarquia 
    public string Id;
    public string nombre;
    public int vida;
    public int magia;
    EnemigoB enemigoB;


    // Start is called before the first frame update
    void Start()
    {
        //acceder a todos los datos de enemigo b (leer un compónente)
        enemigoB = FindObjectOfType<EnemigoB>();
        //va a leer un sistema de busqueda
        BusquedaEnemigo(Id);

    }

    private void BusquedaEnemigo(string id)
    {
        //de la base de datos enemigo, leer objetos de la lista enemigo 
        for (int i=0; i<enemigoB.enemigo.Count; i++)
        {
            if (id==enemigoB.enemigo[i].nombre)
            {
                //si encuentras el dato de ese bloque, a la variable agregale el balor siguiente
                nombre = enemigoB.enemigo[i].nombre;
                vida = enemigoB.enemigo[i].vida;
                magia = enemigoB.enemigo[i].magia;
            }
        }
    }
  

}
