using System;
using System.Collections.Generic;
using System.Text;

namespace State_Auto.States
{
    interface IState
    {
         void FillTank();
         void TurnKey();
         void Drive();
         void Stop();
    }
}
