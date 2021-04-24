using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIcontrol : MonoBehaviour
{
    public NavMeshAgent agent; 
    
    // Pega um objeto na sena
    // Start is called before the first frame update
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        
        // pega o componente do objeto
    }

    
}
