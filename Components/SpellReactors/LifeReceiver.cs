using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeReceiver : BaseReceiver
{
    [SerializeField] private int HP;

    void Awake()
    {
        activeEffects = new List<Effect>();
        HP = entityDef.getMaxHP();
    }

    void Update() {
        if(HP <= 0) {
            EntityManager.instance.removeEnemy(gameObject);
        }
    }

    public override void addEffect(Effect effect, string element)
    {
        activeEffects.Add(effect);
        IEnumerator coroutine = lifeCoroutine((Life)effect, element);
        StartCoroutine(coroutine);
    }

    IEnumerator lifeCoroutine(Life effect, string element)
    {
        float elapsed = effect.getDuration();
        // aplicamos resistencias elementales
        float mod = 1;
        if(gameObject.TryGetComponent(out ResistanceReceiver resistanceReceiver)) {
            mod = resistanceReceiver.getResistance(element);
        }
        float dmg = effect.getMagnitude() * mod;
        while(elapsed > 0)
        {
            HP = Mathf.Min(entityDef.getMaxHP(), HP + (int)dmg);
            if(gameObject.tag == "Player") UIManager.instance.setHealth(HP);

            elapsed--;
            yield return new WaitForSeconds(1);
        }
        // una vez se ha acabado, eliminamos el efecto
        // de la lista y finalizamos la coroutine
        activeEffects.Remove(effect);
        yield break;
    }
}
