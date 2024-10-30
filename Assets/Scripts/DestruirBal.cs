using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirBal : MonoBehaviour
{
    private Rigidbody rb;

    private float delimitarBalaY = -10;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > delimitarBalaY)
        {
            Destroy(gameObject);
        }
    }
}
