using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.StatePattern
{
    public class SprintState : IState
    {
        // color to change player (alternately: pass in with constructor)
        private Color meshColor = Color.yellow;
        public Color MeshColor { get => meshColor; set => meshColor = value; }

        private PlayerController player;

        // pass in any parameters you need in the constructors
        public SprintState(PlayerController player)
        {
            this.player = player;
        }

        public void Enter()
        {
            // code that runs when we first enter the state
            //Debug.Log("Entering Sprint State");
        }

        // per-frame logic, include condition to transition to a new state
        public void Execute()
        {
            // if we are no longer grounded, transition to jumping
            if (!player.IsGrounded)
            {
                player.PlayerStateMachine.TransitionTo(player.PlayerStateMachine.jumpState);
            }

            // if we slow to within a minimum velocity, transition to idling/standing
            if (Mathf.Abs(player.CharController.velocity.x) < 0.1f && Mathf.Abs(player.CharController.velocity.z) < 0.1f)
            {
                player.PlayerStateMachine.TransitionTo(player.PlayerStateMachine.idleState);
            }

            // if sprint key released, transition back to walking
            if (!player.IsSprinting)
            {
                player.PlayerStateMachine.TransitionTo(player.PlayerStateMachine.walkState);
            }
        }

        public void Exit()
        {
            // code that runs when we exit the state
            //Debug.Log("Exiting Sprint State");
        }

    }
}
