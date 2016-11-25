using UnityEngine;
using System.Collections;

public class MYDrone : MonoBehaviour 
{
    public GameObject target;
    NavMeshAgent agent;
	// Use this for initialization
	void Start () 
	{
        agent = GetComponent<NavMeshAgent>();
        agent.destination = target.transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
	    
	}
}
