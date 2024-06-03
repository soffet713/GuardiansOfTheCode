using System;
using System.Collections.Generic;
using System.Text;

namespace GuardiansOfTheCode.Multiplayer
{
    public interface IState
    {
        void Expire();
        void Pay();
    }
}
