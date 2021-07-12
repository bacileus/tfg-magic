using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : Impact
{
    private int time;

    public Destroy(int time) {
        this.time = time;
    }

    public int getTime() {
        return time;
    }

    public override Type getComponentType()
    {
        return typeof(SpellDestroy);
    }
}
