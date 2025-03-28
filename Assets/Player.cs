using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{

    private NavMeshAgent agent;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();



        // Оп : ==, !=, >, <, <=, >=

        // Умову : значення1 оп значення2

        //if (Умова)
        //{
        //    Що буде відбуватись, якщо умова є правдивою
        //}

        var randomNumber = Random.Range(1, 100);

        if (randomNumber > 50)
        {
            Debug.Log("Число більше 50");
        }

        Debug.Log(randomNumber);

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




        //Debug.Log(agent.velocity.magnitude);
    }
}
