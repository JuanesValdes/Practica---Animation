using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemigoB : MonoBehaviour
{
    public List<Enemigo> enemigo;
    // la "base de datos" de los enemigos, va listado con el script del Enemigo para así mandarlo llamar de aquí con valores especiales
    void Awake()
    {
        enemigo.Add(new Enemigo(100, 400, "bee"));
        enemigo.Add(new Enemigo(200, 500, "mummy"));
        enemigo.Add(new Enemigo(100, 300, "mush"));
        enemigo.Add(new Enemigo(1000, 1000, "Bones"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
