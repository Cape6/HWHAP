using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState_FastEnemy : BaseState_FastEnemy
{
    GameObject fast;

    public override void EnterState(StateManager_FastEnemy fast)
    {
        Debug.Log("Fast enemy is now in the patrol state");
    }

    public override void UpdateState(StateManager_FastEnemy fast)
    {
        Debug.Log("updating patrol");
    }
}
