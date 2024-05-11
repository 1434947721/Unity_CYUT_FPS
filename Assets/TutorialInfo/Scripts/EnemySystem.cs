using UnityEngine;
using UnityEngine.AI;

public class ESystem : MonoBehaviour
{
    [SerializeField, Header("Player")]
    private Transform playerPoint;
    [SerializeField, Header("DH")]
    private NavMeshAgent agent;

    private void Update()
    {
        agent.SetDestination(playerPoint.position);
    }
}
