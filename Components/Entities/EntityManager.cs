using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class EntityManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> enemies;
    [SerializeField] private GameObject player;
    private static EntityManager s_instance;
    
    void Awake()
    {
        Assert.IsTrue(s_instance == null);
        Debug.Assert(s_instance == null);

        s_instance = this;
        enemies = new List<GameObject>();
    }

    public static EntityManager instance
    {
        get
        {
            Assert.IsTrue(s_instance != null);
            Debug.Assert(s_instance != null);

            return s_instance;
        }
    }

    public List<GameObject> getEnemies() {
        return enemies;
    }

    public GameObject getPlayer() {
        return player;
    }

    public void addEnemy(GameObject enemy) {
        enemies.Add(enemy);
    }

    public void removeEnemy(GameObject enemy) {
        enemies.Remove(enemy);
        Destroy(enemy);
    }
}
