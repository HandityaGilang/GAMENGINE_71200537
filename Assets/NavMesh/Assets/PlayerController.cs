using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
//using Unity.UnityStandardAssets.ThirdPerson;

//using Assets/Example05 - LowMan/LowMan/Scripts/ThirdPersonCharacter.cs

public class PlayerController : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent agent;

    //public ThirdPersonCharacter character;

    /*void Start()
    {
        agent.updateRotation = false;
    }*/

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }

            /*if (agent.remainingDistande > agent.stoppingDistance)
            {
                character.Move(agent.desrableVelocity, false, false);
            } else
            {
                character.Move(Vector3.zero, false, false);
            }*/
        }
    }
}
