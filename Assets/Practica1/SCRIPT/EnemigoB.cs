using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemigoB : MonoBehaviour
{
    public List<Enemigo> enemigo;
    // Start is called before the first frame update
    void Awake()
    {
        enemigo.Add(new Enemigo(100, 400, "bee"));
        enemigo.Add(new Enemigo(200, 500, "mummy"));
        enemigo.Add(new Enemigo(100, 300, "mush"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
