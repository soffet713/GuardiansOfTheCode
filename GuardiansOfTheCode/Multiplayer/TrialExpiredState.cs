using System;
using System.Collections.Generic;
using System.Text;

namespace GuardiansOfTheCode.Multiplayer
{
    public class TrialExpiredState : IState
    {
        private SubscriptionManager _manager;
        public TrialExpiredState(SubscriptionManager manager)
        {
            _manager = manager;
        }
        public void Expire()
        {
            throw new InvalidOperationException("Cannot expire an expired subscription");
        }

        public void Pay()
        {
            Console.WriteLine("Paid Membership"); ;
            _manager.CurrentState = new PaidState(_manager);
        }
    }
}
