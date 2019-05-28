using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TEST_2 : MonoBehaviour
{
    public float lookRadius = 10f; //범위를 

    Transform target;      //타켓을 누구로
    NavMeshAgent agent;   //내비 시스템
    
    // Start is called before the first frame update
    void Start()
    {
        target = PlayerManger.instance.player.transform;        //캐릭터를 어떻게 찾느냐
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if ( distance <= lookRadius)
        {
            agent.SetDestination(target.position);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, lookRadius);
    }
}
