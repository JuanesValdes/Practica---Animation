using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [Header("Aqui va tu objeto vacio model")]
    public GameObject model;


    float velocidad;
    Animator anim;
    float velocidadLateral;
    float rotationSpeed = 2f;
    Quaternion targetModelRotation;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        velocidad = 6;
        velocidadLateral = 6;
        targetModelRotation = Quaternion.Euler(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        ControlMovimiento();
        Ataque();


    } //Fin de Update;
        void ControlMovimiento()
        { 
            float vertical = Input.GetAxis("Vertical");
            float horizontal = Input.GetAxis("Horizontal");

 
            Vector3 direccion = new Vector3(horizontal * velocidad * Time.deltaTime, 0, vertical * velocidad * Time.deltaTime);

            transform.Translate(direccion);
            anim.SetFloat("Velocidad", vertical * velocidad);
            anim.SetFloat("velocidadLateral", horizontal * velocidadLateral);
            direccion.Normalize();

            if (direccion.z > 0)
            {
                targetModelRotation = Quaternion.Euler(0, 0, 0);
            }

            else if (direccion.z < 0)
            {
                targetModelRotation = Quaternion.Euler(0, 180, 0);
            }

            if (direccion.x > 0)
            {
                targetModelRotation = Quaternion.Euler(0, 90, 0);
            }

            if (direccion.x < 0)
            {
                targetModelRotation = Quaternion.Euler(0, 270, 0);
            }


        }

    void Ataque()
    {
        if(Input.GetMouseButtonDown(0))
        {
            anim.SetBool("Ataque",true);
        }

        else
        {
            anim.SetBool("Ataque", false);
        }

    }


}

