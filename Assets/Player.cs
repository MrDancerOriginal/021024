using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{

    private NavMeshAgent agent;
    public Animator Animator;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();



        // Оп : ==, !=, >, <, <=, >=

        // Умову : значення1 оп значення2

        //if (Умова)
        //{
        //    Що буде відбуватись, якщо умова є правдивою
        //}

        

    }
    void Update()
    {
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
                agent.SetDestination(hit.point);

        }


        if(agent.velocity.magnitude < 1)
        {
            //Анімація стояння
            Animator.SetBool("isWalk", false);
        }
        
        if(agent.velocity.magnitude > 1 ) 
        {
            //Анімація ходіння
            Animator.SetBool("isWalk", true);
        }

        Debug.Log(agent.velocity.magnitude);
    }
}
