using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class SMTest : MonoBehaviour
{
    [SerializeField] private Transform _objetivo;
    [SerializeField] private float _rangoValido = 1;

    // definimos las 4 partes relevantes de la maquina de estados

    // ESTADOS
    private State _eFeliz, _eTriste, _eHambriento, _eDormido;

    // SIMBOLOS
    private Symbol _sPegar, _sAlimentar, _sJugar;

    // ESTADO ACTUAL (DE ENTRADA VA A SER EL INICIAL)
    private State _actual;

    private Component _comportamientoActual;
    
    // Start is called before the first frame update
    void Start()
    {
        Assert.IsNotNull(_objetivo, "OBJETIVO NO PUEDE SER NULO EN SMTEST");
        
        // ESTADOS
        _eFeliz = new State("FELIZ", typeof(FelizBehaviour));
        _eTriste = new State("TRISTE", typeof(TristeBehaviour));
        _eHambriento = new State("HAMBRIENTO", typeof(HambrientoBehaviour));
        _eDormido = new State("DORMIDO", typeof(DormidoBehaviour));

        // SIMBOLOS
        _sPegar = new Symbol("PEGAR");
        _sAlimentar = new Symbol("ALIMENTAR");
        _sJugar = new Symbol("JUGAR");

        // ESTADO INICIAL
        _actual = _eFeliz;
        _comportamientoActual = gameObject.AddComponent(_actual.Comportamiento);
        

        // FUNCIÓN DE TRANSICIÓN
        _eFeliz.AgregarTransicion(_sPegar, _eTriste);
        _eFeliz.AgregarTransicion(_sJugar, _eHambriento);

        _eTriste.AgregarTransicion(_sPegar, _eDormido);

        _eDormido.AgregarTransicion(_sAlimentar, _eFeliz);

        _eHambriento.AgregarTransicion(_sAlimentar, _eDormido);
        
        StartCoroutine(ChecarDistancia());
    }

    private void ActualizarEstado(Symbol simbolo)
    {
        State nuevoEstado = _actual.AplicarSimbolo(simbolo);

        if(nuevoEstado == _actual)
            return;
    
        _actual = nuevoEstado;
        Destroy(_comportamientoActual);
        _comportamientoActual = gameObject.AddComponent(_actual.Comportamiento);
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.P))
            //ActualizarEstado(_sPegar);

        if(Input.GetKeyDown(KeyCode.C))
            ActualizarEstado(_sAlimentar);

        if(Input.GetKeyDown(KeyCode.J))
            ActualizarEstado(_sJugar);
        
        //print(_actual.Nombre);
    }

    IEnumerator ChecarDistancia()
    {
        while(true)
        {
            float distancia = Vector3.Distance(transform.position, _objetivo.position);
            if(distancia < _rangoValido)
                ActualizarEstado(_sPegar);
            
            yield return new WaitForSeconds(0.5f);
        }
    }
}
