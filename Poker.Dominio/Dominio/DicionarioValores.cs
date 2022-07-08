using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Dominio.Dominio
{
    public static class DicionarioValores
    {
        public static Dictionary<char, int> Cartas = new Dictionary<char, int>() 
                {{'2',1 },{'3',2 },{'4',3 },{'5',4 },{'6',5 },{'7',6 },{'8',7 },{'9',8 },{'D',9 },{'J',10 },{'K',11 },{'A',12 } };

        public static Dictionary<char, int> Naipe = new Dictionary<char, int>()
                {{'O',1 },{'E',2 },{'C',3 },{'P',4 } };
    }
}
