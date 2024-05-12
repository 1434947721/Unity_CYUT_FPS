using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class ESystem : MonoBehaviour
{
    [SerializeField, Header("Player")]
    private Transform playerPoint;
    [SerializeField, Header("DH")]
    private NavMeshAgent agent;
    [SerializeField, Header("anime")]
    private Animator ani;
    [SerializeField, Header("atk_area")]
    private GameObject attackArea;

    private string parMove = "Move_nb";
    private string parAttack = "atk";
    private bool isAttacking;

    private void Update()
    {
        Move();
        Attack();
    }

    private void Move()
    {
        agent.SetDestination(playerPoint.position);

        ani.SetFloat(parMove, agent.velocity.magnitude / agent.speed);
    }

    private void Attack()
    {
        if (isAttacking) return;

        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            ani.SetTrigger(parAttack);
            isAttacking = true;
            StartCoroutine(StartAttack());
        }
    }

    private IEnumerator StartAttack() 
    {
        print("atk");
        yield return new WaitForSeconds(0.1f);
        print("tak");
        attackArea.SetActive(true);
        yield return new WaitForSeconds(0.6f);
        print("kta");
        attackArea.SetActive(false);
        isAttacking = false;
    }
}
