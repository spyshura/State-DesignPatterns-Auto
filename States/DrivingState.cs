using System;
using System.Collections.Generic;
using System.Text;

namespace State_Auto.States
{
    class DrivingState : IState
    {
        private readonly Car _car;
        public DrivingState(Car car)
        {
            _car = car;
        }

        public void FillTank()
        {
            Console.WriteLine("На ходу заправляться нельзя!!!");
        }

        public void TurnKey()
        {
            Console.WriteLine("На ходу ключ не трогай!!!");
        }

        public void Drive()
        {
              TryDrive();
        }

        public void Stop()
        {
            Console.WriteLine("Накатался? Постоим...");
            _car.SetState(_car.EngineStarted);
        }

        private void TryDrive()
        {
            if (_car.Gasoline > 0)
            {
                Console.WriteLine("Goooo!");
            }
            else
            {
                Console.WriteLine("Докатались... безнина больше нет...");
                _car.SetState(_car.EmptyTank);
            }
        }
    }
}
