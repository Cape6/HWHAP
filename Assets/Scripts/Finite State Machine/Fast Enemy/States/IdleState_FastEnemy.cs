using UnityEngine;

public class IdleState_FastEnemy : BaseState_FastEnemy
{
    GameObject fast;

    public override void EnterState(StateManager_FastEnemy fast)
    {
        Debug.Log("Fast enemy is now in the idle state");
    }

    public override void UpdateState(StateManager_FastEnemy fast)
    {
        Debug.Log("updating idle");
    }
}
