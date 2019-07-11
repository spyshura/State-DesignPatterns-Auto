using System;
using System.Collections.Generic;
using System.Text;

namespace State_Auto.States
{
    class EngineStartedState : IState
    {
        private readonly Car _car;
        public EngineStartedState(Car car)
        {
            _car = car;
        }

        public void FillTank()
        {
            Console.WriteLine("Нельзя заправляться с работающим двигателем");
        }

        public void TurnKey()
        {
            Console.WriteLine("Тссссс. Передышка.");
            _car.SetState(_car.FullTank);
        }

        public void Drive()
        {
            TryDrive();
        }

        public void Stop()
        {
            Console.WriteLine("Я и так стою");
        }

        private void TryDrive()
        {
            if (_car.Gasoline > 0)
            {
                Console.WriteLine("Goooo!");
                _car.SetState(_car.DrivingState);
            }
            else
            {
                Console.WriteLine("Докатались... безнина больше нет...");
                _car.SetState(_car.EmptyTank);
            }
        }
    }
}
