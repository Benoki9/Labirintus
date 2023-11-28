using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Transform unit;
    private UnityEngine.AI.NavMeshAgent agent;
    private Animator anim;
    public float Health {get; set;}
    public float Damage {get; set;}
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        anim = GetComponent<Animator>();
        Health = 500;
        Damage = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
