using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitController : MonoBehaviour
{
    private UnityEngine.AI.NavMeshAgent agent;
    private Animator anim;
    private RaycastHit hit;
    private MySelectable ms;
    
    public static float delay = 0.5f;
    private float health;
    public float Damage {get; set;}
    public float Health{get {return health;} set {health = value;}}
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        anim = GetComponent<Animator>();
        ms = GetComponent<MySelectable>();
        Health = 500;
        Damage = 100;
    }

    // Update is called once per frame
    void Update()
    {
        foreach(var soldier in MySelectable.allMySelectables){
             anim.SetFloat("Running", agent.remainingDistance);
            if(soldier.selected){
                if(Input.GetMouseButtonDown(0)){
                   
                    if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)){
                        agent.destination = hit.point;
                    }
                }
            }
        }
    }
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Enemy"){
            agent.destination = other.gameObject.transform.position;
            anim.SetBool("Attack", true);
        }
    }
}
