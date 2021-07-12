using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseReceiver : MonoBehaviour
{
    protected List<Effect> activeEffects;
    [SerializeField] protected EntityDef entityDef;

    public bool containsEffect(Effect effect) {
        return activeEffects.Contains(effect);
    }

    public abstract void addEffect(Effect effect, string element);

    public EntityDef getEntityDef() {
        return entityDef;
    }
}
