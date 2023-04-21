using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Assertions;

public class RaycastMouse : MonoBehaviour
{

    [SerializeField] NavMeshAgent _agent;

    // Start is called before the first frame update
    void Start()
    {
        Assert.IsNotNull(_agent, "AGENTE NO PUEDE SER NULO");
    }

    // Update is called once per frame
    void Update()
    {
        // detectar si jugador dio click a algo o no 
        if(Input.GetMouseButtonDown(0))
        {
            // obtener rayo de mouse
            Ray rayito = Camera.main.ScreenPointToRay(Input.mousePosition);


            // CONDICIONES PARA HACER RAYCASTING
            // - objetos tienen collider
            // - layer no es "ignore raycast"

            // con quién choqué?
            // (nombre, posición, etc)

            RaycastHit infoHit;

            // hacer raycast
            if(Physics.Raycast(rayito, out infoHit))
            {
                print(string.Format("SÍ PEGUÉ! {0} {1}", infoHit.transform.name, infoHit.point));
                _agent.destination = infoHit.point;
            }
        }
    }
}
