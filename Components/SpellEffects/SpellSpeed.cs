using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellSpeed : SpellEffect
{
    protected override void OnTriggerStay(Collider collider)
    {
        GameObject other = collider.gameObject;
        bool isCaster = effect.getWise() && other.transform == configSpell.getCaster();

        if(!isCaster && other.TryGetComponent(out MovementReceiver movementReceiver) && !movementReceiver.containsEffect(effect))
        {
            movementReceiver.addEffect(effect, elementName);
        }
    }
}
