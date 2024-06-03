﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardiansOfTheCode
{
    public class Giant : IEnemy
    {
        private int _health;
        private readonly int _level;

        public int Health { get => _health; set => _health = value; }

        public int Level => _level;

        public int OvertimeDamage { get; set; }
        public int Armor { get; set; }
        public bool Paralyzed { get; set; }
        public int ParalyzedFor { get; set; }

        public Giant(int health, int level)
        {
            _health = health;
            _level = level;
        }

        public int Attack(PrimaryPlayer player)
        {
            Console.WriteLine("Giant attacks " + player.Name);
            return 30;
        }

        public void Defend(PrimaryPlayer player)
        {
            Console.WriteLine("Giant defends from " + player.Name);
        }
    }
}
