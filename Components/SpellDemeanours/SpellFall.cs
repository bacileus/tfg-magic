using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellFall : SpellDemeanour
{
    private Fall fall;
    
    protected override void Start()
    {
        base.Start();
        fall = (Fall)configSpell.getSpell().getDemeanour();
        gameObject.transform.position += fall.getHeight() * Vector3.up;
    }

    protected override void Update()
    {
        gameObject.transform.position += 2.5f * Physics.gravity * Time.deltaTime;
    }
}
