using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoInfinito : MonoBehaviour
{
    public float velocidad = 5.0f;
    public float profundidadFondo = 10.0f;

    private Vector3 posicionInicial;

    void Start()
    {
        posicionInicial = transform.position;
    }

    void Update()
    {
        MoverFondo();
        RepeatingFondo();
    }

    void MoverFondo()
    {
        transform.Translate(Vector3.back * velocidad);
    }

    void RepeatingFondo()
    {
        if (transform.position.z < posicionInicial.z - profundidadFondo)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, posicionInicial.z + profundidadFondo);
        }
    }
}

