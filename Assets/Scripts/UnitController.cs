using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitController : MonoBehaviour
{
    private UnityEngine.AI.NavMeshAgent agent;
    private Animator anim;
    private RaycastHit hit;
    private MySelectable ms;
    
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        anim = GetComponent<Animator>();
        ms = GetComponent<MySelectable>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach(var soldier in MySelectable.allMySelectables){
            if(soldier.selected){
                if(Input.GetMouseButtonDown(0)){
                    if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)){
                        agent.destination = hit.point;
                    }
                }
            }
        }
    }
}
