using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine
{
    public IPlayerState CurrentState { get; private set; }

    public void init(IPlayerState playerState)
    {
        CurrentState = playerState;
        CurrentState.Enter();
    }

    public void ChangeState(IPlayerState playerState)
    {
        CurrentState.Exit();
        CurrentState = playerState;
        CurrentState.Enter();
    }
}
