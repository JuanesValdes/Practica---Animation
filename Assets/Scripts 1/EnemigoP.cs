using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoP : Persecucion
{
    // el hijo del script persecución, sirve para dar diferentes atributos si asi lo deseamos a diferentes objetos pero que al llamar el código pers, hace la misma función sin necesidad de otro código
    void Start()
    {
        playerPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Perseguir(playerPosition, this.gameObject.transform);
    }
}
