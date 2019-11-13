using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persecucion : MonoBehaviour
{
    public Transform playerPosition;
    public float velocidadEnemigo;

    // Start is called before the first frame update
    void Start()
    {
        playerPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Perseguir(playerPosition,this.gameObject.transform);
    }

    public void Perseguir (Transform player, Transform enemigo)
    {
        Vector3 distancia = player.position - enemigo.position;

        enemigo.LookAt(distancia);
        enemigo.Translate(distancia.normalized * velocidadEnemigo * Time.deltaTime);
    }
}
