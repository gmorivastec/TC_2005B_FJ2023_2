using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{
    
    
    // RECOMENDACIÓN
    // con cualquier manager centralizado hacer singleton

    void Start()
    {
        // si necesitamos un objeto que permanezca a través de las escens
        // usamos esto
        DontDestroyOnLoad(gameObject);
    }

    public void EscucharBoton() 
    {
        print("PRESIONASTE BOTÓN");
        //SceneManager.LoadScene("ScriptableObjects");
        SceneManager.LoadScene(1);
    }

    public void EscucharSlider(float valor)
    {
        print(string.Format("valor de slider: {0}", valor));
    }

    public void Salir()
    {
        print("SALIR");
        Application.Quit();
    }
}
