using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agente : MonoBehaviour
{
    [SerializeField]
    protected float velocidad;

    [SerializeField]
    protected Transform destino;

    [SerializeField]
    protected float freno;

    [SerializeField]
    protected float distanciaMeta;

    [SerializeField]
    protected Transform objetivo;

    // declaramos la forma en que se trasladará en base a su velocidad establecida,cambiando de posición 
    protected void ConfigurarDestino(Transform d)
    {
        Vector3 destinoFinal = new Vector3(d.position.x, this.transform.position.y, d.position.z);
        ConfiguracionFreno(destinoFinal, freno);

        transform.LookAt(destinoFinal);
        
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);

    }

    //aquí manejamos la velocidad en la que se detendrá, a cierta distancia de un punto
    protected bool ConfiguracionFreno(Vector3 d,float f)
    {
        float velocidadLocal = 1;
        float distancia = Vector3.Distance(transform.position, d);

        if (distancia < f)
        {
            velocidad = 0;
            return (true);
        }
        else
        {
            velocidad = velocidadLocal;
            return (false);
        }
    }

    // declaramos la distancia del objetivo para poder definir su posición 
    protected float MedirDistancia()
    {
        Vector3 metaPos = new Vector3(objetivo.position.x, this.transform.position.y, objetivo.position.z);
        float distancia = Vector3.Distance(transform.position, metaPos);
        Debug.Log(distancia);
        return distancia;

    }

    protected bool MedirDistanciaBool()
    {
        Vector3 metaPos = new Vector3(objetivo.position.x, this.transform.position.y, objetivo.position.z);
        float distancia = Vector3.Distance(transform.position, metaPos);

        if (distancia < distanciaMeta)
            return true;
        else
            return false;
    }
}
