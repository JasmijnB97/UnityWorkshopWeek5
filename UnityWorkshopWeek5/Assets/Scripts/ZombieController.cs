using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieController : MonoBehaviour
{
    private NavMeshAgent agent;

    public Transform player;
    public float detectionRange;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void FixedUpdate()
    {
        if (Vector3.Distance(transform.position, player.position) <= detectionRange)
        {
            agent.SetDestination(player.position);
        }
    }
}
