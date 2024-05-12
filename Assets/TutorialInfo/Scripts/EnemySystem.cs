using UnityEngine;
using UnityEngine.AI;

public class ESystem : MonoBehaviour
{
    [SerializeField, Header("Player")]
    private Transform playerPoint;
    [SerializeField, Header("DH")]
    private NavMeshAgent agent;
    [SerializeField, Header("anime")]
    private Animator ani;

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
        }
    }
}
