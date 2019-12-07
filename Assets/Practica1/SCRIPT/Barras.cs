using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barras : MonoBehaviour
{
    public Slider[] barras;
    public int vida;
    CEnemigo vidaEnemigo;

    // iniciamos checando el enemigo  y se le asigna una barra determinada con sus valores
    void Start()
    {
        vidaEnemigo = GetComponentInParent<CEnemigo>();


        StartCoroutine ("asignarBarra");

    }

    // actualizando constantemente checamos el status de la barra de "vida" y "magia" 
    void Update()
    {
        barras[0].value = vidaEnemigo.vida;
        if ( vidaEnemigo.vida ==0)
        {
            transform.parent.gameObject.SetActive(false);
        }
    }

    // usamos corrutinas para mandar a llamar a este procedimiento cada que se cumpla una instancia específica 
    IEnumerator asignarvida()
    {
        yield return new WaitForSeconds(1);
        if (vidaEnemigo !=null)
        {
            vida = vidaEnemigo.vida;
            barras[0].maxValue = vida;
            barras[0].value = barras[0].maxValue;
        }
    }

    IEnumerator asignarBarra ()
    {
        yield return new WaitForSeconds(1);
        barras = new Slider[2];
        barras = GetComponentsInChildren<Slider>();
        vida = vidaEnemigo.vida;
        for (int i = 0; i < barras.Length; i++)
        {
            barras[i] = barras[i];
            if (i == 0)
            {
                barras[i].maxValue = vida;
                barras[i].value = barras[i].maxValue;
            }
        }
    }
}
