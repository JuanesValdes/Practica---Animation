using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CEnemigo : Agente
{
    public string Id;
    public string nombre;
    public int vida;
    public int magia;
    EnemigoB enemigoB;
    Animator animMomia;

    // mandamos llamar al objeto enemigo de la baase de datos de enemigos por su ID para así poderlo crear
    void Start()
    {
        enemigoB = FindObjectOfType<EnemigoB>();
        BusquedaEnemigo(Id);

        animMomia = GetComponent<Animator>();
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

    private void Update()
    {
        ConfigurarDestino(destino);

        animMomia.SetFloat("velocidad", velocidad);
    }
        
}
