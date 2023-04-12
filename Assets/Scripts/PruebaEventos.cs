using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

// para eventos con 1 o más argumentos hay que definir una clase
[Serializable]
public class EventoUnArgumento : UnityEvent<int>{}

[Serializable]
public class EventoDosArgumentos : UnityEvent<string, float>{}

[Serializable]
public class EventoTresArgumentos : UnityEvent<bool, string, char>{}

public class PruebaEventos : MonoBehaviour
{

    [Serializable]
    private class Alumno
    {
        public string _nombre;
        public int _edad;
        public float _altura;
    }

    // UNITY EVENTS
    // - mecanismo basado en el patrón de diseño de observador 
    // por el que informamos de un cambio en alguna situación
    
    // GRAN VENTAJA
    // desacopla lógica (remueve dependencias duras)

    // CUANDO USARLO
    // - cuando queramos poner un objeto de el tipo de otro script
    // evalua si un event no resuelve el problema
    [SerializeField] private Alumno[] _alumnos;
    [SerializeField] private UnityEvent _eventoSinParametros;
    [SerializeField] private EventoUnArgumento _eventoUnArgumento;
    [SerializeField] private EventoDosArgumentos _eventoDosArgumentos;
    [SerializeField] private EventoTresArgumentos _eventoTresArgumentos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            _eventoSinParametros.Invoke();
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            _eventoUnArgumento.Invoke(10);
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            _eventoDosArgumentos.Invoke("hola", 4.8f);
        }

        if(Input.GetKeyDown(KeyCode.F))
        {
            _eventoTresArgumentos.Invoke(true, "adios", 'x');
        }
    }
}
