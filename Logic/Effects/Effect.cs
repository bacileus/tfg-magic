using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Effect
{
    // modificador (por segundo) que sumaremos/restaremos al LifeSystem 
    protected float magnitude;
    // si duration == 1, la magnitud sera instantanea
    // en caso contrario la magnitud se aplicara durante x segundos
    protected float duration;

    protected bool isWise;
    protected EffectDef effectDef;

    public Effect(int magnitude, float duration, bool isWise, EffectDef effectDef) {
        this.magnitude = magnitude;
        this.duration = duration;
        this.isWise = isWise;
        this.effectDef = effectDef;
    }

    public float getMagnitude() {
        return magnitude;
    }

    public float getDuration() {
        return duration;
    }

    public bool getWise() {
        return isWise;
    }

    public EffectDef getEffectDef() {
        return effectDef;
    }

    public abstract Type getComponentType();
}
