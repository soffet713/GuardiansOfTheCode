using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardiansOfTheCode.Strategies
{
    public class RegularDamageIndicator : IDamageIndicator
    {
        public void NotifyAboutDamage(int health, int damage)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Player took {damage} damage points, {health} HP remaining");
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
