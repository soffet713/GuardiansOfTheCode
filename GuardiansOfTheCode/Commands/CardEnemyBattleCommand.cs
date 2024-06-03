using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GuardiansOfTheCode.Commands
{
    public class CardEnemyBattleCommand : ICommand
    {
        private Card _card;

        private IEnemy _enemy;

        public CardEnemyBattleCommand(Card card, IEnemy enemy)
        {
            _card = card;
            _enemy = enemy;
        }

        public void Execute()
        {
            _enemy.Health -= _card.Attack;
        }
    }
}
