using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellInstant : SpellDemeanour
{
    private Instant instant;

    protected override void Start()
    {
        base.Start();
        instant = (Instant)configSpell.getSpell().getDemeanour();
    }
}
