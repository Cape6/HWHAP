using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState_FastEnemy : BaseState_FastEnemy
{
    GameObject fast;

    public override void EnterState(StateManager_FastEnemy fast)
    {
        Debug.Log("Fast enemy is now in the attack state");
    }

    public override void UpdateState(StateManager_FastEnemy fast)
    {
        Debug.Log("updating attack");
    }
}
