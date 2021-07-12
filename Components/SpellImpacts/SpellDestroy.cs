using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellDestroy : SpellImpact
{
    private Destroy destroy;
    [SerializeField] private float elapsed;
    [SerializeField] private bool startCount;

    protected override void Start()
    {
        base.Start();
        destroy = (Destroy)configSpell.getSpell().getImpact();
        elapsed = 0;
        startCount = false;
    }

    void Update()
    {
        if(startCount) {
            elapsed += Time.deltaTime;
            if(elapsed > destroy.getTime()) Destroy(gameObject);
        }
    }

    protected override void OnTriggerEnter(Collider collider)
    {
        startCount = true;
    }
}
