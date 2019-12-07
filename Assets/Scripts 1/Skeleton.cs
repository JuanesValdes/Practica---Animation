using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : Agente
{
    public string Id;
    public string nombre;
    public int vida;
    public int magia;
    public float _velocidadAgente;

    EnemigoB enemigoB;
    Animator anim;

    void Start()
    {
        _velocidadAgente = velocidad;
        enemigoB = FindObjectOfType<EnemigoB>();


        BusquedaEnemigo(Id);

        this.anim = GetComponent<Animator>();
        destino = GameObject.Find("Destino").GetComponent<Transform>();
        objetivo = GameObject.Find("Destino").GetComponent<Transform>();

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
        if (MedirDistanciaBool())
        {
            ConfigurarDestino(destino);

            if (MedirDistancia() <= freno)
            {
                Debug.Log("Tomaaaaa");
                anim.SetBool("Ataque", true);

            }
            else
            {
                anim.SetBool("Ataque", false);

            }
        }
        else if (!MedirDistanciaBool())
        {
            _velocidadAgente = 0;
        }

        if (anim != null)
        {
            anim.SetFloat("velocidad", _velocidadAgente);
        }
    }
        
}
