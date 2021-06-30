using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveState : IPlayerState
{
    public enum CharacterState {North,South,Side }
    protected CharacterState characterState = CharacterState.South;
    public Player player { get; }
    public PlayerStateMachine StateMachine { get; set; }
    public string _animBoolName { get; }

    public PlayerMoveState(Player player, PlayerStateMachine playerStateMachine, string animBoolName)
    {
        this.player = player;
        StateMachine = playerStateMachine;
        _animBoolName = animBoolName;

    }
    public void DoChecks()
    {

    }

    public void Enter()
    {
        Debug.Log("anim name is " + _animBoolName);
        player.Anim.SetBool(_animBoolName, true);
        Debug.Log(_animBoolName);
    }

    public void Exit()
    {
        player.Anim.SetBool(_animBoolName, false);
    }

    public virtual void LogicUpdate()
    {
        player.Anim.SetFloat("Speed", player.input.AnimSpeed);
/*        Debug.LogFormat("input is x({0}) y({1})", player.input.RawInput.x, player.input.RawInput.y);*/
       
    }

    public void physicsUpdate()
    {
        DoChecks();
    }
}
