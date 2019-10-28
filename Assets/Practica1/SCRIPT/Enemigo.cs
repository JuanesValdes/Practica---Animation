using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Enemigo 
{
    public int vida;
    public int magia;
    public string nombre;

    public  Enemigo(int v, int m, string n)
    {
        //recibir  parametros
        this.nombre = n;
        this.vida = v;
        this.magia = m;


    }
  

      
  
}
