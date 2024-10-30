using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveController : MonoBehaviour
{
    public float velocidad = 5.0f;
    public float rangoMovimiento = 5.0f;

    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");

        transform.Translate(new Vector3(movimientoHorizontal, 0, 0) * velocidad);

        if (transform.position.x < -rangoMovimiento)
        {
            transform.position = new Vector3(-rangoMovimiento, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > rangoMovimiento)
        {
            transform.position = new Vector3(rangoMovimiento, transform.position.y, transform.position.z);
        }

    }
}