using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveStateSide : PlayerMoveState
{
    public PlayerMoveStateSide(Player player, PlayerStateMachine playerStateMachine, string animBoolName) : base(player, playerStateMachine, animBoolName)
    {
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
        player.CheckIfShouldFlip((int)player.input.RawInput.x * -1);
        if (Mathf.Abs(player.input.RawInput.x) > 0) return;
        
       
        if (player.input.RawInput.y > 0)
        {
            player.CheckIfShouldFlip(1);
            StateMachine.ChangeState(player.moveStates[0]);
        }
        else if (player.input.RawInput.y < 0)
        {
            player.CheckIfShouldFlip(1);
            StateMachine.ChangeState(player.moveStates[1]);
        }
    }
}
