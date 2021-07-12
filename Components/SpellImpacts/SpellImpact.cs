using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpellImpact : MonoBehaviour
{
    protected ConfigSpell configSpell;
    
    protected virtual void Start() {
        configSpell = gameObject.GetComponent<ConfigSpell>();
    }

    protected abstract void OnTriggerEnter(Collider collider);
}
