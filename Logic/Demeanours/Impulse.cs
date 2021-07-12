using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulse : Demeanour
{
    private int speed;

    public Impulse(int speed) {
        this.speed = speed;
    }

    public override Type getComponentType()
    {
        return typeof(SpellImpulse);
    }

    public float getSpeed() {
        return speed;
    }
}
