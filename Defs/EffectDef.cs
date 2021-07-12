using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Effect (Def)", menuName = "Scriptable/Effect", order = 3)]
public class EffectDef : ScriptableObject
{
    [SerializeField] private Material material;

    public Material getMaterial() {
        return material;
    }
}
