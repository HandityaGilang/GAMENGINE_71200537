using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class AgentController : MonoBehaviour
{
    public bool MoveNow ;
    public GameObject Target;

    void Start()
    {
        
    }

    void Update()
    {
        if(MoveNow == true)
        {
            GetComponent<NavMeshAgent>().SetDestination(Target.transform.position);
        }
    }
}
