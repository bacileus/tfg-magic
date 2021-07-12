using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ricochet : Impact
{
    private int max_impacts;

    public Ricochet(int max_impacts) {
        this.max_impacts = max_impacts;
    }

    public int getMaxImpacts() {
        return max_impacts;
    }

    public override Type getComponentType() {
        return typeof(SpellRicochet);
    }
}
