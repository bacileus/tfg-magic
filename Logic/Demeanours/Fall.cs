using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : Demeanour
{
    private int height;

    public Fall(int height) {
        this.height = height;
    }

    public override Type getComponentType()
    {
        return typeof(SpellFall);
    }

    public int getHeight() {
        return height;
    }
}
