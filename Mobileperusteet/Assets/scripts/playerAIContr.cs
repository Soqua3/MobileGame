using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class playerAIContr : MonoBehaviour
{
    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            RaycastHit hit;
            Vector3 touchPoint = Input.GetTouch(0).position;
            Ray ray = Camera.main.ScreenPointToRay(touchPoint);

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
    }
}
