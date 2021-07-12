using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellMultiple : SpellImpact
{
    private Multiple multiple;
    private int wave;
    private Rigidbody rb;

    protected override void Start() {
        base.Start();
        multiple = (Multiple)configSpell.getSpell().getImpact();
        wave = 0;
        rb = gameObject.GetComponent<Rigidbody>();
    }

    protected override void OnTriggerEnter(Collider collider)
    {
        rb.velocity = Vector3.zero;
        IEnumerator coroutine = spawnWave();
        StartCoroutine(coroutine);
    }

    IEnumerator spawnWave() {
        Spell original = configSpell.getSpell();
        Spell copy = new Spell(original.getElement(), original.getShape(), original.getEffect(), new Fall(30), new Destroy(1));
        
        while(wave < multiple.getMaxWaves()) {
            // dibujamos hexagono
            for(int i = 0; i < 6; i++) {
                float angle = (2 * Mathf.PI / 6) * i;
                Vector3 position = 
                    gameObject.transform.position + new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * 3;
                GameObject instance = 
                    Instantiate(copy.getShape().getShapeDef().getParticleSystem(), position, gameObject.transform.rotation).gameObject;
                ConfigSpell configSpell = instance.AddComponent<ConfigSpell>();
                configSpell.setConfigSpell(copy, transform);
            }
            wave++;
            yield return new WaitForSeconds(1);
        }
        Destroy(gameObject);
        yield break;
    }
}
