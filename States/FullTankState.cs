using System;
using System.Collections.Generic;
using System.Text;

namespace State_Auto.States
{
    class FullTankState : IState
    {
        private readonly Car _car;
        public FullTankState(Car car)
        {
            _car = car;
        }

        public void FillTank()
        {
            Console.WriteLine("Бак полный, больше заправить нельзя!");
        }

        public void TurnKey()
        {
            Console.WriteLine("Завелись!!!");
            _car.SetState(_car.EngineStarted);
        }

        public void Drive()
        {
            Console.WriteLine("Заведи машину, ну");
        }

        public void Stop()
        {
            Console.WriteLine("Я и так стою");
        }
    }
}
