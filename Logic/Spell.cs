using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell
{
    private ElementDef element;
    private Shape shape;
    private Effect effect;
    private Demeanour demeanour;
    private Impact impact;

    // base spell
    /*
    public Spell()
    {
        this.element = Resources.Load<ElementDef>("Elements/Fire");
        this.shape = new Self();
        this.effect = new Speed(100, 5, false);
        this.demeanour = new Child();
        this.impact = new Multiple(3);
    }
    */

    public Spell(ElementDef element, Shape shape, Effect effect, Demeanour demeanour, Impact impact)
    {
        this.element = element;
        this.shape = shape;
        this.effect = effect;
        this.demeanour = demeanour;
        this.impact = impact;
    }

    // GETTERS
    public ElementDef getElement()
    {
        return element;
    }

    public Shape getShape()
    {
        return shape;
    }

    public Effect getEffect()
    {
        return effect;
    }

    public Demeanour getDemeanour()
    {
        return demeanour;
    }

    public Impact getImpact()
    {
        return impact;
    }
}