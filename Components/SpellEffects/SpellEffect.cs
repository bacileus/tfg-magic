using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpellEffect : MonoBehaviour
{
    protected ConfigSpell configSpell;
    protected Effect effect;
    [SerializeField] protected string elementName;

    protected virtual void Start() {
        configSpell = gameObject.GetComponent<ConfigSpell>();
        effect = configSpell.getSpell().getEffect();
        elementName = configSpell.getSpell().getElement().getName();
    }

    public Effect getEffect() {
        return effect;
    }

    public string getElementName() {
        return elementName;
    }

    public void setElementName(string elementName) {
        this.elementName = elementName;
    }

    protected abstract void OnTriggerStay(Collider collider);
}
