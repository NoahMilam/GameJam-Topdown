using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveDownState : PlayerMoveState
{
    public PlayerMoveDownState(Player player, PlayerStateMachine playerStateMachine, string animBoolName) : base(player, playerStateMachine, animBoolName)
    {
    }
    public override void LogicUpdate()
    {
        base.LogicUpdate();
        if (player.input.RawInput.y < 0) return;
            
     
        if (player.input.RawInput.y > 0)
        {
            StateMachine.ChangeState(player.moveStates[0]);
        }
        else if (Mathf.Abs(player.input.RawInput.x) > 0) {
            StateMachine.ChangeState(player.moveStates[2]);
        }
    }
}
