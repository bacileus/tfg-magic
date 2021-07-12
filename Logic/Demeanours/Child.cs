using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Child : Demeanour
{
    public Child() {}
    
    public override Type getComponentType()
    {
        return typeof(SpellParent);
    }
}
