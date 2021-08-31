using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIControl1 : MonoBehaviour {

	GameObject[] goalLocations;
	UnityEngine.AI.NavMeshAgent agent;
    Animator anim;
    Vector3 lastGoal;
    public static AIControl1 instance;

	// Use this for initialization
	void Start () {
		goalLocations = GameObject.FindGameObjectsWithTag("goal");
		agent = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
        anim = GetComponent<Animator>();
        anim.SetBool("isWalking", true);
        PickGoalLocation();
	}

    public static AIControl1 Singleton
    {
        get
        {
            if (instance == null)
            {
                instance = new AIControl1();
            }
            return instance;
        }
    }

    void PickGoalLocation()
    {
        lastGoal = agent.destination;
        GameObject goalPosition = PeopleMovement.Singleton.GetRandomPositions();
        agent.SetDestination(goalPosition.transform.position);

    }

	
	// Update is called once per frame
	void Update () {
        if (agent.remainingDistance < 1) //At the goal
        {
            PickGoalLocation();
        }
        foreach(GameObject item in PeopleMovement.Singleton.Obstacles)
        {
            float distance = Vector3.Distance(item.transform.position, this.transform.position);
            if (distance<5 && Random.Range(0,100)<5)
            {
                agent.SetDestination(lastGoal);
            }
            else if(distance<1)
            {
                PeopleMovement.Singleton.RemoveObstacles(item);
                break;
            }
        }
	}
}
