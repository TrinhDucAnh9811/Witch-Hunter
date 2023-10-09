using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Allie : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5.0f;
    [SerializeField] private float a_currentHealth;
    [SerializeField] private float a_maxHealth = 10.0f;
    private Vector3 moveDirection;
    private Rigidbody alliesRb;

    private NavMeshAgent allies;

    void Start()
    {
        alliesRb = GetComponent<Rigidbody>();
        a_currentHealth = a_maxHealth;

        allies = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        /*if(PlayerController.instance.transform.position !=null)
        {
            enemy.SetDestination(PlayerController.instance.transform.position);*/
            /*Vector3 direction = (PlayerController.instance.transform.position - transform.position).normalized;
            float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
            alliesRb.rotation = Quaternion.Euler(0, angle,0);
            moveDirection = direction;*/
     /*   }  */  
    }

    private void FixedUpdate()
    {
        /*if (PlayerController.instance.transform.position != null)
        {
            alliesRb.velocity = new Vector3(moveDirection.x, moveDirection.y, moveDirection.z) * moveSpeed;
        }    */
    }
}
