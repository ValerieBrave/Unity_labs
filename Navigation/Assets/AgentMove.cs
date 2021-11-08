using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class AgentMove : MonoBehaviour
{
    [SerializeField]
    Transform _destination;
    NavMeshAgent _agent;
    void Start()
    {
        _agent = this.GetComponent<NavMeshAgent>();
        SetDestination();
    }

    
    private void SetDestination() {
        if(_destination != null) {
            Vector3 targetVector = _destination.transform.position;
            _agent.SetDestination(targetVector);
        }
    }
}
