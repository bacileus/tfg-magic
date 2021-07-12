using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : Effect
{
    public Life(int magnitude, float duration, bool isWise, EffectDef effectDef) : base(magnitude, duration, isWise, effectDef)
    {
    }

    public override Type getComponentType()
    {
        return typeof(SpellLife);
    }
}
