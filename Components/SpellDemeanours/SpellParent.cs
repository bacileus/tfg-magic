using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellParent : SpellDemeanour
{
    protected override void Start()
    {
        base.Start();
        Transform parent = gameObject.GetComponent<ConfigSpell>().getCaster();
        transform.SetParent(parent);
        transform.localPosition = Vector3.zero;
    }
}
