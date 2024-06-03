using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardiansOfTheCode.Strategies
{
    public class CriticalHealthIndicator : IDamageIndicator
    {
        public void NotifyAboutDamage(int health, int damage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"HEALTH CRITICAL! {damage} damage points taken, {health} HP remaining");
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
