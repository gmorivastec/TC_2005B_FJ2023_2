using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // existen métodos de conveniencia para uso de raycast con objeto
    // CONDICIONES DE RAYCAST SON LAS MISMAS

    	

    

    // MOUSE ENTRÓ, NO IMPORTA EL CLICK
    void OnMouseEnter() 
    {
        print("ON MOUSE ENTER");
    }	

    void OnMouseOver() 
    {
        //print("ON MOUSE OVER");
    }	

    // MOUSE SALIÓ, NO IMPORTA EL CLICK
    void OnMouseExit() 
    {
        print("ON MOUSE EXIT");
    }	


    // DIMOS CLICK SOBRE OBJETO
    void OnMouseDown() 
    {
        print("ON MOUSE DOWN");
    }

    // DIMOS CLICK Y DESPUES ARRASTRAMOS
    void OnMouseDrag() 
    {
        //print("ON MOUSE DRAG");        
    }	

    void OnMouseUp() 
    {
        print("ON MOUSE UP");
    }
    

    void OnMouseUpAsButton() 
    {
        print("ON MOUSE UP AS BUTTON");
    }

    
    	
    
}
