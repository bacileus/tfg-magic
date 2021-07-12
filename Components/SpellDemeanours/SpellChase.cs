using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellChase : SpellDemeanour
{
    private Chase chase;

    protected override void Start()
    {
        base.Start();
        chase = (Chase)configSpell.getSpell().getDemeanour();
    }

    protected override void Update()
    {
        List<GameObject> enemies = EntityManager.instance.getEnemies();
        GameObject nearest = null;
        float distance = float.MaxValue;
        foreach(GameObject enemy in enemies) {
            float t_distance = Vector3.Distance(gameObject.transform.position, enemy.transform.position);
            if(t_distance < distance) {
                distance = t_distance;
                nearest = enemy;
            }
        }
        if (nearest != null && distance > 0.5f && distance <= chase.getRange()) {
            gameObject.transform.LookAt(nearest.transform);
            gameObject.transform.Translate(Vector3.forward * Time.fixedDeltaTime * chase.getSpeed());
        }
    }
}
