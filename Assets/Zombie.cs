using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour
{
    NavMeshAgent agent;
    public Animator anim;
    public GameObject Ninja;
    // Start is called before the first frame update
    void Start()
    {
        foreach(var x in GetComponentsInChildren<Rigidbody>()){
            x.isKinematic = true;
        }
        agent=GetComponent<NavMeshAgent>();
        
    }
    // Update is called once per frame
    void Update()
    {
            if (agent.velocity.sqrMagnitude>0)
            {
                anim.SetBool("Walk",true);
            }
            else
            {
                anim.SetBool("Walk",false);
            }
       if(Vector3.Distance (Ninja.transform.position,this.transform.position)<10)
        agent.SetDestination(Ninja.transform.position- transform.forward);
        if(Vector3.Distance(this.transform.position,Ninja.transform.position)<2)
        {
            anim.SetBool("Punch",true);
        }
        else
        {
            anim.SetBool("Punch",false);
        }
    }
}
