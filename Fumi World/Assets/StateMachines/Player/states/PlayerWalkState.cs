using SkateWorld.FinalCharacterController;
using UnityEngine;

public class PlayerWalkState : PlayerBaseState
{
    public PlayerWalkState(PlayerStateMachine currentContext, PlayerStateFactory playerStateFactory) : base(currentContext, playerStateFactory) 
    { }
    public override void EnterState() { }

    public override void UpdateState() { }

    public override void ExitState() { }

    public override void CheckSwitchStates() { }

    public override void InitializeSubState() { }
}
