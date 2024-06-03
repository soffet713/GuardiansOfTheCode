using Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardiansOfTheCode.Proxies
{
    internal class CardsProxy
    {
        private HttpClient _http;
        private IEnumerable<Card> _cards;

        public CardsProxy()
        {
            _http = new HttpClient();
        }

        public async Task<IEnumerable<Card>> GetCards()
        {
            if (_cards != null)
            {
                return _cards;
            }
            else
            {
                await FetchCards();
                return _cards;
            }
        }

        private async Task FetchCards()
        {
            var cardsJson = await _http.GetStringAsync("http://localhost:5053/api/cards");
            _cards = JsonConvert.DeserializeObject<IEnumerable<Card>>(cardsJson);
        }
    }
}
