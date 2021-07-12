using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multiple : Impact
{
    private int max_waves;

    public Multiple(int max_waves) {
        this.max_waves = max_waves;
    }

    public int getMaxWaves() {
        return max_waves;
    }

    public override Type getComponentType()
    {
        return typeof(SpellMultiple);
    }
}
