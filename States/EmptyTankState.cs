using System;
using System.Collections.Generic;
using System.Text;

namespace State_Auto.States
{
    class EmptyTankState : IState
    {
        private readonly Car _car;
        public EmptyTankState(Car car)
        {
            _car = car;
        }

        public void FillTank()
        {
            Console.WriteLine("Теперь бак полный");
            _car.SetState(_car.FullTank);
        }
        public void TurnKey()
        {
            Console.WriteLine("Без бензина не работаю");
        }

        public void Drive()
        {
            Console.WriteLine("Без бензина не работаю, сори");
        }

        public void Stop()
        {
            Console.WriteLine("Без бензина не работаю, Я и так стою");
        }

    }
}
