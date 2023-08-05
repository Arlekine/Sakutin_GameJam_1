using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent), typeof(Animator))]
public class UnicornEnemy : Enemy
{
    [SerializeField] private NavMeshAgent _agent;
    [SerializeField] private Animator _animator;
    [SerializeField] private Transform _target;

    [SerializeField] private float _distance;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _distance = Vector3.Distance(_target.position, transform.position);

        if(_distance > 10)
        {
            _agent.enabled = false;

            _animator.SetBool("isRunning", false);
        }
        else if( _distance < 10)
        {
            _agent.enabled = true;
            _agent.SetDestination(_target.position);


            _animator.SetBool("isRunning", true);
        }
    }
}
