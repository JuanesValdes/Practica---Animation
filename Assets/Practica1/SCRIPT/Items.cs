using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Items 
{
    public int vida;
    public int uso;
    public string nombre;

    public  Items(int v, int u, string n)
    {
        //recibir  parametros
        this.uso = u;
        this.vida = v;
        this.nombre = n;


    }
  

      
  
}
