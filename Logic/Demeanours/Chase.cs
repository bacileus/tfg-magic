using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : Demeanour
{
    private int speed;
    private int range;

    public Chase(int speed) {
        this.speed = speed;
        this.range = 15;
    }

    public override Type getComponentType()
    {
        return typeof(SpellChase);
    }

    public int getSpeed() {
        return speed;
    }

    public int getRange() {
        return range;
    }
}
