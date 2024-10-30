using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoController : MonoBehaviour
{
    public GameObject balaPrefab;

    public float velocidadDisparo = 10.0f;
    public float tiempoRecarga = 1.0f;
    private string botonDisparo = "Fire1";
 
    void Update()
    {
        if (Input.GetButtonDown(botonDisparo) && tiempoRecarga <= 0)
        {
            Disparar();
            tiempoRecarga = 1.0f;
        }
        else
        {
            tiempoRecarga -= 0.1f;
        }
    }

    void Disparar()
    {
        GameObject bala = Instantiate(balaPrefab, transform.position, transform.rotation);
        bala.GetComponent<Rigidbody>().velocity = transform.forward * velocidadDisparo;

        AudioG.instance.PlaySFX(0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Metorito")) 
        { 
            Destroy(collision.gameObject); 
            Destroy(gameObject);

            AudioG.instance.PlaySFX(1);
        }
        
    }

}