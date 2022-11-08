using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathState_FastEnemy : BaseState_FastEnemy
{
    GameObject fast;

    public override void EnterState(StateManager_FastEnemy fast)
    {
        Debug.Log("Fast enemy is now in the death state");
    }

    public override void UpdateState(StateManager_FastEnemy fast)
    {
        Debug.Log("updating death");
    }
}
