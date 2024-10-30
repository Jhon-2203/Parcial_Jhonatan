using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorMeteorito : MonoBehaviour
{

    public float rangoMaxX = 13;
    public float rangoMaxZ= 13;

    public GameObject meteoritos;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("PuntoGeneradorMeteorito", 1, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PuntoGeneradorMeteorito()
    {
        float rangoX = Random.Range(-rangoMaxX, rangoMaxX);

        Vector3 ubicacionMeteorito = new Vector3(rangoX, 0, rangoMaxZ);

        Instantiate(meteoritos, ubicacionMeteorito, meteoritos.transform.rotation);
    }
}
