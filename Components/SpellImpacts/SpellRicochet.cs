using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellRicochet : SpellImpact
{
    private Ricochet ricochet;
    private int impacts;
    private Vector3 cur_direction;
    private Rigidbody rb;

    protected override void Start() {
        base.Start();
        ricochet = (Ricochet)configSpell.getSpell().getImpact();
        impacts = 0;
        rb = gameObject.GetComponent<Rigidbody>();
        cur_direction = rb.velocity;
    }

    protected override void OnTriggerEnter(Collider collider) {
        impacts++;
        if(impacts >= ricochet.getMaxImpacts()) Destroy(gameObject);
        else {
            RaycastHit hit;
            Transform transform = gameObject.transform;
            Physics.Raycast(transform.position, transform.forward, out hit);
            cur_direction = Vector3.Reflect(cur_direction, hit.normal);

            rb.velocity = cur_direction;
        }
    }
}
