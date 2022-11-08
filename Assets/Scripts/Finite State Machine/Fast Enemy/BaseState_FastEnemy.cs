using UnityEngine;

public abstract class BaseState_FastEnemy
{
    public abstract void EnterState(StateManager_FastEnemy fast);

    public abstract void UpdateState(StateManager_FastEnemy fast);
}
