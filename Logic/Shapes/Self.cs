using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Self : Shape
{
    public Self()
    {
        // valor pequeño para asegurar que solo afecta al jugador
        this.col_radius = 0.1f;
        this.shapeDef = Resources.Load<ShapeDef>("Shapes/Self");
    }

    public override float getEmitRadius() {
        return shapeDef.getParticleSystem().shape.radius;
    }
}
