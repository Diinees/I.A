using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agentmanager : MonoBehaviour
{
    GameObject[] agentes; 
    
    // Criação de array

    // Start is called before the first frame update
    void Start()
    {
        agentes = GameObject.FindGameObjectsWithTag("Ai");
        
        // Busca os agentes
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
            
            // Se o mouse for apertado 
        {
            RaycastHit hit; // Se tiver colisao

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
                
                // Se a linha do raycast tiver fora de colisão executa o foreach
            {
                foreach (GameObject a in agentes) 
                    a.GetComponent<AIcontrol>().agent.SetDestination(hit.point);
                
                // nova posicao no mundo
            }


        }



    }
}
