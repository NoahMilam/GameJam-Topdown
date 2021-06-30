using UnityEngine;

public interface IPlayerState
{
    Player player { get; }
    PlayerStateMachine StateMachine { get; }
    void Enter();
    void Exit();
    void LogicUpdate();
    void physicsUpdate();
    void DoChecks();
}
