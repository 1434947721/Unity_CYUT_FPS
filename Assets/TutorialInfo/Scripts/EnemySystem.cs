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
    private string parAttack = "New Trigger";

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        agent.SetDestination(playerPoint.position);

        ani.SetFloat(parMove, agent.velocity.magnitude / agent.speed);
    }
}
