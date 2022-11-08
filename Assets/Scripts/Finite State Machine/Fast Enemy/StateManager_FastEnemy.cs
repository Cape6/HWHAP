using UnityEngine;

public class StateManager_FastEnemy : MonoBehaviour
{
    BaseState_FastEnemy currentState;

    public IdleState_FastEnemy idle = new IdleState_FastEnemy();
    public PatrolState_FastEnemy patrol = new PatrolState_FastEnemy();
    public AttackState_FastEnemy attack = new AttackState_FastEnemy();
    public DeathState_FastEnemy death = new DeathState_FastEnemy();

    private void Start()
    {
        currentState = idle;
        currentState.EnterState(this);
    }

    private void Update()
    {
        currentState.UpdateState(this);
    }

    public void switchState(BaseState_FastEnemy state)
    {
        currentState = state;
        state.EnterState(this);
    }
}
