using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCMovementScript : MonoBehaviour
{
    public Vector3[] points;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(points[currentPointIndex]);
    }

    int currentPointIndex = 0;

    void IncrementPointIndex()
    {
        if (currentPointIndex >= points.Length - 1)
            currentPointIndex = 0;
        else
            currentPointIndex++;
        agent.SetDestination(points[currentPointIndex]);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(agent.remainingDistance);
        if (agent.remainingDistance == 0.0f || agent.remainingDistance == Mathf.Infinity)
            IncrementPointIndex();
    }

    private void OnDrawGizmosSelected()
    {
        foreach(Vector3 vector in points)
        {
            Gizmos.DrawSphere(vector, 0.5f);
        }
    }
}
