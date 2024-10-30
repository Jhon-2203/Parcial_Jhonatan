using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuvMeteorito : MonoBehaviour
{

    public float velocidadMeteorito = 0f;
    private float rangoDelimitadoZ = -70;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(0, 0, -1 * velocidadMeteorito);

        if (transform.position.z < rangoDelimitadoZ)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Nave"))
        {
          
            UnityEngine.SceneManagement.SceneManager.LoadScene("Juego");
        }
    }
}
