using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioG : MonoBehaviour
{

    public static AudioG instance;

    public AudioSource[] efectoSonido;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySFX (int sonidoInicial)
    {
        efectoSonido[sonidoInicial].Play();
    }
}
