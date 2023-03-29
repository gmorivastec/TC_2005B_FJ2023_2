using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Carta", menuName = "Mis Scriptable Objects/Carta", order = 1)]
public class CartaSO : ScriptableObject
{
    
    public string _nombre;
    public string _fuerza;
    public Sprite _sprite;
}
