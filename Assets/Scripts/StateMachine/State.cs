using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class State 
{
    public string Nombre
    {
        get;
        private set;
    }

    private Dictionary<Symbol, State> Transicion
    {
        get;
        set;
    }

    public Type Comportamiento
    {
        get;
        private set;
    }

    public State(string nombre, Type comportamiento) 
    {
        Nombre = nombre;
        Comportamiento = comportamiento;
        Transicion = new Dictionary<Symbol, State>();
    }

    public void AgregarTransicion(Symbol simbolo, State estado)
    {
        Transicion.Add(simbolo, estado);
    }

    public State AplicarSimbolo(Symbol simbolo)
    {
        if(Transicion.ContainsKey(simbolo))
            return Transicion[simbolo];
        
        return this;
    }
}
