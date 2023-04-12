using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaOyente : MonoBehaviour
{
    public void EventoSinParametros() 
    {
        print("EVENTO SIN PARAMETROS");
    }

    public void EventoUnParametro(int param)
    {
        print(string.Format("parametros: {0}", param));
    }

    public void EventoDosParametros(string p1, float p2)
    {
        print(string.Format("parametros: {0} {1}", p1, p2));
    }

    public void EventoTresParametros(bool p1, string p2, char p3)
    {
        print(string.Format("parametros: {0} {1} {2}", p1, p2, p3));
    }
}
