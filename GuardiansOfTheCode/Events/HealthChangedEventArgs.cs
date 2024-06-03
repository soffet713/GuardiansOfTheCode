using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardiansOfTheCode.Events
{
    public class HealthChangedEventArgs : EventArgs
    {
        public int Health { get; private set; }
        public int Damage { get; set; }

        public HealthChangedEventArgs(int health)
        {
            Health = health;
        }
    }
}
