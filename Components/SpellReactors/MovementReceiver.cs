using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovementReceiver : BaseReceiver
{
    [SerializeField] private float currentSpeed;
    private NavMeshAgent agent;
    private Camera cam;
    
    void Awake()
    {
        activeEffects = new List<Effect>();
        currentSpeed = entityDef.getMoveSpeed();
        agent = gameObject.GetComponent<NavMeshAgent>();
        cam = Camera.main;
    }

    public bool move(Vector3 destination) {
        NavMeshPath path = new NavMeshPath();
        bool b = agent.CalculatePath(destination, path);
        if(b) agent.SetDestination(destination);
        return b;
    }

    public override void addEffect(Effect effect, string element)
    {
        activeEffects.Add(effect);
        IEnumerator coroutine = speedCoroutine((Speed)effect, element);
        StartCoroutine(coroutine);
    }

    private IEnumerator speedCoroutine(Speed effect, string element)
    {
        float mod = 1;
        if(gameObject.TryGetComponent(out ResistanceReceiver resistanceReceiver)) {
            mod = resistanceReceiver.getResistance(element);
        }
        float d_speed = currentSpeed * ((effect.getMagnitude() / 100.0f) * mod);
        currentSpeed += d_speed;
        agent.speed = currentSpeed;
        yield return new WaitForSeconds(effect.getDuration());
        currentSpeed -= d_speed;
        agent.speed = currentSpeed;
        activeEffects.Remove(effect);
        yield break;
    }
}