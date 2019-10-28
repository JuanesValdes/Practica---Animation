using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearItems : MonoBehaviour
{
    //crear jerarquia 
    public string Id;
    public string nombre;
    public int vida;
    public int uso;
    ItemsB itemb;


    // Start is called before the first frame update
    void Start()
    {
        //acceder a todos los datos de enemigo b (leer un compónente)
        itemb = FindObjectOfType<ItemsB>();
        //va a leer un sistema de busqueda
        BusquedaItem(Id);

    }

    private void BusquedaItem(string id)
    {
        //de la base de datos enemigo, leer objetos de la lista enemigo 
        for (int i=0; i<itemb.item.Count; i++)
        {
            if (id==itemb.item[i].nombre)
            {
                //si encuentras el dato de ese bloque, a la variable agregale el balor siguiente
                nombre = itemb.item[i].nombre;
                vida = itemb.item[i].vida;
                uso = itemb.item[i].uso;
            }
        }
    }
  

}
