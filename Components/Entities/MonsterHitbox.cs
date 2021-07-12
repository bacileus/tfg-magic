using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterHitbox : MonoBehaviour
{
    private Effect effect;
    private string elementName;

    void Awake() {
        effect = new Life(-10, 1, false, null);
        elementName = "Ice";
    }

    protected void OnTriggerStay(Collider collider)
    {
        GameObject other = collider.gameObject;
        bool isPlayer = other.tag == "Player";
        
        if(isPlayer && other.TryGetComponent(out LifeReceiver lifeReceiver) && !lifeReceiver.containsEffect(effect))
        {
            lifeReceiver.addEffect(effect, elementName);
        }
    }
}
