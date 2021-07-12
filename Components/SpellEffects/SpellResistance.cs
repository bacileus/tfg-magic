using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellResistance : SpellEffect
{
    protected override void OnTriggerStay(Collider collider)
    {
        GameObject other = collider.gameObject;
        bool isCaster = effect.getWise() && other.transform == configSpell.getCaster();

        if(!isCaster && other.TryGetComponent(out ResistanceReceiver resistanceReceiver) && !resistanceReceiver.containsEffect(effect))
        {
            resistanceReceiver.addEffect(effect, elementName);
        }
    }
}
