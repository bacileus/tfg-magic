using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigSpell : MonoBehaviour
{
    private Spell i_spell;
    [SerializeField] private Transform caster;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.layer = LayerMask.NameToLayer("Spell");

        Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
        rigidbody.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotation;
        rigidbody.angularDrag = 0;

        // element
        ParticleSystem particleSystem = gameObject.GetComponent<ParticleSystem>();
        particleSystem.startColor = i_spell.getElement().getColor();

        // shape
        SphereCollider sphereCollider = gameObject.AddComponent<SphereCollider>();
        sphereCollider.center = Vector3.zero;
        sphereCollider.radius = i_spell.getShape().getColRadius();
        sphereCollider.isTrigger = true;
        ParticleSystem.ShapeModule shape = particleSystem.shape;
        shape.radius = i_spell.getShape().getEmitRadius();

        // effect
        ParticleSystemRenderer particleSystemRenderer = gameObject.GetComponent<ParticleSystemRenderer>();
        Type effect = i_spell.getEffect().getComponentType();
        particleSystemRenderer.material = i_spell.getEffect().getEffectDef().getMaterial();
        gameObject.AddComponent(effect);

        // action
        Type demeanour = i_spell.getDemeanour().getComponentType();
        gameObject.AddComponent(demeanour);

        // impact
        if(i_spell.getImpact() != null) {
            Type impact = i_spell.getImpact().getComponentType();
            gameObject.AddComponent(impact);
        }
    }

    public Spell getSpell() {
        return i_spell;
    }

    public Transform getCaster() {
        return caster;
    }

    public void setConfigSpell(Spell i_spell, Transform caster) {
        this.i_spell = i_spell;
        this.caster = caster;
    }
}
