using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResistanceReceiver : BaseReceiver
{
    private Dictionary<string, float> elementalResistances;

    void Awake()
    {
        activeEffects = new List<Effect>();
        elementalResistances = new Dictionary<string, float>();
        int i = 0;
        foreach(ElementDef element in Resources.LoadAll<ElementDef>("Elements")) {
            elementalResistances.Add(element.getName(), entityDef.getResistance(i));
            i++;
        }
    }

    public float getResistance(string element)
    {
        return elementalResistances[element];
    }

    public override void addEffect(Effect effect, string element)
    {
        activeEffects.Add(effect);
        IEnumerator coroutine = resistanceCoroutine((Resistance)effect, element);
        StartCoroutine(coroutine);
    }

    IEnumerator resistanceCoroutine(Resistance effect, string element)
    {
        float magnitude = effect.getMagnitude()/100.0f;
        elementalResistances[element] -= magnitude;
        yield return new WaitForSeconds(effect.getDuration());
        elementalResistances[element] += magnitude;
        activeEffects.Remove(effect);
        yield break;
    }
}
