using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baraja : MonoBehaviour
{
    // carga de recursos desde archivos en runtime
    // https://docs.unity3d.com/ScriptReference/Resources.Load.html

    [SerializeField] private CartaSO[] _cartas;
    [SerializeField] private CartaLoader[] _cartasEnEscena;

    void Start()
    {
        AleatorizarCartas();
    }

    public void AleatorizarCartas()
    {
        for(int i = 0; i < _cartasEnEscena.Length; i++)
        {
            _cartasEnEscena[i]._datos = _cartas[Random.Range(0, _cartas.Length)];
            _cartasEnEscena[i].CargarDatosDeCarta();
        }
    }
}
