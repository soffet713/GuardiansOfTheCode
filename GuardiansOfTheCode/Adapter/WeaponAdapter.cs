using MilkyWayponLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardiansOfTheCode.Adapter
{
    public class WeaponAdapter : IWeapon
    {
        private ISpaceWeapon _spaceWeapon;

        public WeaponAdapter(ISpaceWeapon spaceWeapon)
        {
            _spaceWeapon = spaceWeapon;
        }

        public int Damage => _spaceWeapon.ImpactDamage + _spaceWeapon.LaserDamage;

        public void Use(IEnemy enemy)
        {
            enemy.Health -= _spaceWeapon.Shoot();
        }
    }
}
