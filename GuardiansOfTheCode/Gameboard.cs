using Common;
using MilkyWayponLib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardiansOfTheCode
{
    public class Gameboard
    {
        private Facades.GameboardFacade _gameboardFacade;
        private PrimaryPlayer _player;

        public Gameboard()
        {
            _player = PrimaryPlayer.Instance;
            _player.Weapon = new Sword(12, 8);
        }

        public async Task PlayArea(int lvl)
        {
            if (lvl == -1)
            {
                Console.WriteLine("Play special Level?");
                Console.ReadKey();
                PlaySpecialLevel();
            }
            else if (lvl == -1)
            {
                await _gameboardFacade.Play(_player, lvl);
            }
        }

        private void PlaySpecialLevel()
        {
            _player.Weapon = new Adapter.WeaponAdapter(new Blaster(20, 15, 15));
        }
        /*
        public void PlayFirstLevel()
        {
            const int currentLvl = 1;
            EnemyFactory factory = new EnemyFactory(currentLvl);
            List<IEnemy> enemies = new List<IEnemy>();
            for (int i = 0; i < 10; i++)
            {
                enemies.Add(factory.SpawnZombie(currentLvl));
            }

            for (int i = 0; i < 3; i++)
            {
                enemies.Add(factory.SpawnWerewolf(currentLvl));
            }

            foreach (var enemy in enemies)
            {
                while (enemy.Health > 0 || _player.Health > 0)
                {
                    _player.Weapon.Use(enemy);
                    enemy.Attack(_player);
                }
            }
        }

        private async Task<IEnumerable<Card>> FetchCards() 
        {
            using (var http = new HttpClient()) 
            {
                var cardsJson = await http.GetStringAsync("http://localhost:5053/api/cards");
                return JsonConvert.DeserializeObject<IEnumerable<Card>>(cardsJson);
            }
        }
        */
    }
}
