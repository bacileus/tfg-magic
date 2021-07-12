using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Shape (Def)", menuName = "Scriptable/Shape", order = 1)]
public class ShapeDef : ScriptableObject
{
    [SerializeField] private ParticleSystem particleSystem;

    public ParticleSystem getParticleSystem() {
        return particleSystem;
    }
}
