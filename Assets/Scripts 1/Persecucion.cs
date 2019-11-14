using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persecucion : MonoBehaviour
{
    public Transform playerPosition;
    public float velocidadEnemigo;

    // Con playerposition delimitamos la posición del objeto con el tag player para que nuestro enemigo pueda transformar su posición hacia el player

    void Start()
    {
        playerPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Perseguir(playerPosition,this.gameObject.transform);
    }

    // seleccionamos el player como objetivo y hacemos que el enemigo se dirija a su posición
    public void Perseguir (Transform player, Transform enemigo)
    {
        Vector3 distancia = player.position - enemigo.position;

        enemigo.LookAt(distancia);
        enemigo.Translate(distancia.normalized * velocidadEnemigo * Time.deltaTime);
    }
}
