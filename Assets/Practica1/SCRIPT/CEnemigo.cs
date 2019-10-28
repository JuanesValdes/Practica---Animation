﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CEnemigo : MonoBehaviour
{
    public string Id;
    public string nombre;
    public int vida;
    public int magia;
    EnemigoB enemigoB;

    void Start()
    {
        enemigoB = FindObjectOfType<EnemigoB>();
        BusquedaEnemigo(Id);
    }

    private void BusquedaEnemigo(string id )
    {
        for (int i=0; i<enemigoB.enemigo.Count; i++)
        {
            if (id == enemigoB.enemigo[i].nombre)
            {
                nombre = enemigoB.enemigo[i].nombre;
                vida = enemigoB.enemigo[i].vida;
                magia = enemigoB.enemigo[i].magia;
            }
        }
    }
}
