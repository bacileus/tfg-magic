using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : Effect
{
    public Speed(int magnitude, float duration, bool isWise, EffectDef effectDef) : base(magnitude, duration, isWise, effectDef)
    {
    }

    public override Type getComponentType()
    {
        return typeof(SpellSpeed);
    }
}
