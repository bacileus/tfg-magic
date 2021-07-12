using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterVisual : MonoBehaviour
{
    private Animator animator;
    private NavMeshAgent agent;

    void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
        agent = gameObject.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        animator.SetBool("isMoving", agent.remainingDistance >= 0.75f);
        animator.SetBool("isAttacking", agent.remainingDistance <= 1.25f);
    }
}
