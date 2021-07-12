using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instant : Demeanour
{
    public Instant() {}

    public override Type getComponentType()
    {
        return typeof(SpellInstant);
    }
}
