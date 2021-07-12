using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpellDemeanour : MonoBehaviour
{
    protected ConfigSpell configSpell;

    protected virtual void Start() {
        configSpell = gameObject.GetComponent<ConfigSpell>();
    }

    protected virtual void Update() {}
}
