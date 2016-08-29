using UnityEngine;
using System.Collections;

/*
The Navigation script manages the navigation of the corrupted data packets in the sixth level of the game, which is aided
by the NavMesh.
*/
public class Navigation : MonoBehaviour {

    Transform target;           //The data packet's target, or destination
    NavMeshAgent agent;         //The NavMesh instance

	/*
    The Start function intializes the target and the NavMesh agent.
    */
	void Start ()
    {
        target = GameObject.Find("Part160").transform;
        agent = GetComponent<NavMeshAgent>();
	}
	
	/*
    The Update function sets the NavMesh agent's destination. Note that the NavMesh agent resides in each
    corrupted data packet.
    */
	void Update () {
        agent.SetDestination(target.position);
	}
}
