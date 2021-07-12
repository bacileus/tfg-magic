using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterAI : MonoBehaviour
{
    private EntityManager entityManager;
    private MovementReceiver movementReceiver;
    [SerializeField] private int max_range;

    // Start is called before the first frame update
    void Start()
    {
        entityManager = EntityManager.instance;
        entityManager.addEnemy(gameObject);
        movementReceiver = gameObject.GetComponent<MovementReceiver>();   
    }

    // Update is called once per frame
    void Update()
    {
        float distance = 
            Vector3.Distance(transform.position, entityManager.getPlayer().transform.position);

        if(distance < max_range) {
            movementReceiver.move(entityManager.getPlayer().transform.position);
        }
    }
}
