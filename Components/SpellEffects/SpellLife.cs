using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellLife : SpellEffect
{
    protected override void OnTriggerStay(Collider collider)
    {
        GameObject other = collider.gameObject;
        bool isCaster = effect.getWise() && other.transform == configSpell.getCaster();
        
        if(!isCaster && other.TryGetComponent(out LifeReceiver lifeReceiver) && !lifeReceiver.containsEffect(effect))
        {
            lifeReceiver.addEffect(effect, elementName);
        }
    }
}
