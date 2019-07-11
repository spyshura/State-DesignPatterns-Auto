using State_Auto.States;
using System;

namespace State_Auto
{
    class Car
    {
        public int Gasoline { get; private set; }
        public EmptyTankState EmptyTank { get; private set; }
        public FullTankState FullTank { get; private set; }
        public EngineStartedState EngineStarted { get; private set; }
        public DrivingState DrivingState { get; private set; }

        private IState _currentState;


        public Car()
        {
            EmptyTank = new EmptyTankState(this);
            FullTank = new FullTankState(this);
            EngineStarted = new EngineStartedState(this);
            DrivingState = new DrivingState(this);

            _currentState = EmptyTank;
            Gasoline = 0;
        }

        public void FillTank()
        {
            Gasoline = 70;
            _currentState.FillTank();
        }

        public void TurnKey()
        {
            _currentState.TurnKey();
        }

        public void Drive()
        {
            _currentState.Drive();
            Gasoline -= 10;
        }

        public void Stop()
        {
            _currentState.Stop();
        }

        public void SetState(IState state)
        {
            _currentState = state;
        }
    }
}
