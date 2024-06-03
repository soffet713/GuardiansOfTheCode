using System;
using System.Collections.Generic;
using System.Text;

namespace GuardiansOfTheCode.Multiplayer
{
    public class PaidState : IState
    {
        private SubscriptionManager _manager;

        public PaidState(SubscriptionManager manager)
        {
            _manager = manager;
        }

        public void Expire()
        {
            throw new InvalidOperationException("Cannot expire a paid membership");
        }

        public void Pay()
        {
            throw new InvalidOperationException("Cannot pay an already paid service");
        }
    }
}
