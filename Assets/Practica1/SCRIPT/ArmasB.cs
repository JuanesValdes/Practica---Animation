using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ArmasB : MonoBehaviour
{
    public List<Armas> armitas;
    // Start is called before the first frame update
    void Awake()
    {
        armitas.Add(new Armas(10, 40, "rifle"));
        armitas.Add(new Armas(20, 50, "spada"));
        armitas.Add(new Armas(60, 30, "mazo"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
