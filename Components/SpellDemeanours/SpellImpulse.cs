using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellImpulse : SpellDemeanour
{
    private Impulse impulse;

    protected override void Start()
    {
        base.Start();
        impulse = (Impulse)configSpell.getSpell().getDemeanour();
        Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
        rigidbody.velocity = impulse.getSpeed() * gameObject.transform.forward;
    }
}
