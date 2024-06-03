using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardiansOfTheCode.Strategies
{
    public interface IDamageIndicator
    {
        void NotifyAboutDamage(int health, int damage);
    }
}
