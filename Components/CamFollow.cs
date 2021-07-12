using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{    
    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 delta;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = player.transform.position + delta;
        transform.position = pos;
    }
}
