using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navmove : MonoBehaviour
{
    public NavMeshAgent nav;
    public Transform target;
 
    public void Update()
    {
        nav.SetDestination(target.position);
    }
}
