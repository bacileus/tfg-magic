using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape
{
    protected float col_radius;
    protected ShapeDef shapeDef;

    public float getColRadius() {
        return col_radius;
    }

    public ShapeDef getShapeDef() {
        return shapeDef;
    }

    public virtual float getEmitRadius() {
        return col_radius;
    }
}
