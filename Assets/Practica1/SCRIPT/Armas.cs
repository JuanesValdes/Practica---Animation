using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Armas
{
    public int daño;
    public int vidautil;
    public string nombre;

    public  Armas(int v, int d, string n)
    {
        //recibir  parametros
        this.nombre = n;
        this.vidautil = v;
        this.daño = d;


    }
  

      
  
}
