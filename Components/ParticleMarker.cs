using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleMarker : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private ParticleSystem ps;
    
    void Awake()
    {
        ps = gameObject.GetComponent<ParticleSystem>();
    }

    void OnTriggerEnter(Collider collider) {
        if(collider.gameObject == player) {
            ps.Stop();
        }
    }

    public void move(Vector3 position) {
        transform.position = position;
        if(!ps.isEmitting) ps.Play();
    }
}
