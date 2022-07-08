using Poker.Dominio.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Dominio.Dominio.CartadasFinais
{
    public class Carta
    {
        public char _Naipe { get; set; }
        public string _Carta { get; set; }

        public int _ValorNaipe { get; set; }
        public int _ValorCarta { get; set; }

        public Carta(char naipe, string carta)
        {
            _Naipe = naipe;
            _Carta = carta;

            AlimentarValores();
        }
        
        private void AlimentarValores()
        {
            _ValorCarta = DicionarioValores.Cartas[_Carta];
            _ValorNaipe= DicionarioValores.Naipe[_Naipe];
        }

        public override bool Equals(object obj)
        {
            return obj is Carta carta &&
                   _Naipe == carta._Naipe &&
                   _Carta == carta._Carta &&
                   _ValorNaipe == carta._ValorNaipe &&
                   _ValorCarta == carta._ValorCarta;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_Naipe, _Carta, _ValorNaipe, _ValorCarta);
        }
    }
}
