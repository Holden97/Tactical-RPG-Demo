using System;
using CommonBase;

namespace TacticalRPG
{
    [Serializable]
    public class TurnUpdate : BaseState
    {
        public TurnUpdate(string stateName, FiniteStateMachine fsm) : base(stateName, fsm) { }

        public override void OnStateStart() {  }
        public override void OnStateUpdate() {  }
        public override void OnStateEnd() {  }
        public override void OnStateCheckTransition() {  }
        public override void OnReset() {  }
        public override void OnDispose() {  }
    }
}