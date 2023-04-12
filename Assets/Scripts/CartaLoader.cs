using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Assertions;

public class CartaLoader : MonoBehaviour
{
    
    [SerializeField]
    public CartaSO _datos;

    [SerializeField]
    private TMP_Text _nombre;

    [SerializeField]
    private TMP_Text _fuerza;

    [SerializeField]
    private SpriteRenderer _spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {   

        Assert.IsNotNull(_datos, "LOS DATOS DEL PREFAB CARTA NO PUEDEN SER NULOS");
        CargarDatosDeCarta();
    }

    public void CargarDatosDeCarta() 
    {
        _nombre.text = _datos._nombre;
        _fuerza.text = _datos._fuerza;
        _spriteRenderer.sprite = _datos._sprite;
    }

}
