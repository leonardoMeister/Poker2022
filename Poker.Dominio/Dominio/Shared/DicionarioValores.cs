using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Dominio.Dominio.Shared
{
    public static class DicionarioValores
    {
        public static Dictionary<string, int> Cartas = new Dictionary<string, int>() 
                {{"2",1 },{"3",2 },{"4",3 },{"5",4 },{"6",5 },{"7",6 },{"8",7 },{"9",8 },{"10",9 },{"Q",10 },{"J",11 },{"K",12 },{"A",13 } };

        public static Dictionary<char, int> Naipe = new Dictionary<char, int>()
                {{'O',1 },{'E',2 },{'C',3 },{'P',4 } };

        public static Dictionary<EnumTiposMao, int> ValoresMao = new Dictionary<EnumTiposMao, int>()
                { {EnumTiposMao.RoyalFlush,1000 },{EnumTiposMao.StrainghtFlush,900 },{EnumTiposMao.Quadra,800 },
                  {EnumTiposMao.FullHouse,700 },{EnumTiposMao.Flush,600 },{EnumTiposMao.Sequencia,500 },
                  {EnumTiposMao.Trinca,400 },{EnumTiposMao.DoisPares,300 },{EnumTiposMao.UmPar,200 },
                  {EnumTiposMao.CartaAlta,100 } };

    }
}
