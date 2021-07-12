using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area : Shape
{
    public Area(int col_radius) {
        this.col_radius = col_radius;
        this.shapeDef = Resources.Load<ShapeDef>("Shapes/Area");
    }
}
