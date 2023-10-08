using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerGroundedState
{
    public PlayerIdleState(PlayerStateMachine stateMachine, Player player, string animBoolName) : base(stateMachine, player, animBoolName)
    {

    }

    public override void Enter()
    {
        base.Enter();
        player.SetVelocity(0f, 0f);

    }

   

    public override void Update()
    {
        base.Update();

        if (xInput == player.faceDirection && player.IsTouchingWall())
            return;

        if (xInput != 0)
            stateMachine.SwitchState(player.moveState);
    }

    public override void Exit()
    {
        base.Exit();
    }
}
