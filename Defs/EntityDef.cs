using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Entity (Def)", menuName = "Scriptable/Entity", order = 2)]
public class EntityDef : ScriptableObject
{
    [SerializeField] private int maxHP;
    [SerializeField] private float[] elementalResistances;
    [SerializeField] private float moveSpeed;

    public int getMaxHP() {
        return maxHP;
    }

    public float getResistance(int i) {
        return elementalResistances[i];
    }

    public float getMoveSpeed() {
        return moveSpeed;
    }
}
