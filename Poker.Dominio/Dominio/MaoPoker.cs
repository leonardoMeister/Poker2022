using Poker.Dominio.Dominio.CartadasFinais;
using Poker.Dominio.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Dominio.Dominio
{
    public class MaoPoker
    {
        public int ValorDaMao { get; private set; }
        public EnumTiposMao TipoMao { get; private set; }
        public List<Carta> MaoCartas { get; private set; }

        public MaoPoker(List<Carta> maoCartas)
        {
            MaoCartas = maoCartas;
            ValorDaMao = 0;
            ClassificarMao();
        }

        private void ClassificarMao()
        {
            VerificarRoyalFlusch();
            if (ValorDaMao != 0) return;
            VerificarStraightFlusch();
            if (ValorDaMao != 0) return;
            VerificarQuadra();
            if (ValorDaMao != 0) return;
            VerificarFullHouse();
            if (ValorDaMao != 0) return;
            VerificarFlusc();
            if (ValorDaMao != 0) return;
            VerificarSequencia();
            if (ValorDaMao != 0) return;
            VerificarTrinca();
            if (ValorDaMao != 0) return;
            VerificarDoisPares();
            if (ValorDaMao != 0) return;
            VerificarUmPar();
            if (ValorDaMao != 0) return;
            VerificarCartaAlta();

        }
        private void VerificarCartaAlta()
        {
            int valorMaisAlto = MaoCartas[0]._ValorCarta;

            foreach (Carta carta in MaoCartas)
            {
                if (valorMaisAlto < carta._ValorCarta) valorMaisAlto = carta._ValorCarta;
            }
            ValorDaMao = valorMaisAlto;
            TipoMao = EnumTiposMao.CartaAlta;
        }
        private void VerificarUmPar()
        {
            var itens = MaoCartas.GroupBy(x => x._ValorCarta).Where(g => g.Count() == 2).ToList();
            
            if (itens.Count == 1)
            {
                ValorDaMao = DicionarioValores.ValoresMao[EnumTiposMao.UmPar];
                TipoMao = EnumTiposMao.UmPar;
            }
        }
        private void VerificarDoisPares()
        {
            var itens = MaoCartas.GroupBy(x => x._ValorCarta).Where(g => g.Count() == 2).ToList();
            
            if (itens.Count == 2)
            {
                ValorDaMao = DicionarioValores.ValoresMao[EnumTiposMao.DoisPares];
                TipoMao = EnumTiposMao.DoisPares;
            }
        }
        private void VerificarTrinca()
        {         
            var itens = MaoCartas.GroupBy(x => x._ValorCarta).Where(g => g.Count() == 3).ToList();
            
            if (itens.Count == 1) 
            {
                ValorDaMao = DicionarioValores.ValoresMao[EnumTiposMao.Trinca];
                TipoMao = EnumTiposMao.Trinca;
            }
        }
        private void VerificarSequencia()
        {
            bool ehRealmente = true;

            List<Carta> novaLista = new List<Carta>(MaoCartas);

            novaLista = novaLista.OrderBy(x => x._ValorCarta).ToList();

            if (!((novaLista[0]._ValorCarta + 1) == novaLista[1]._ValorCarta
                && (novaLista[1]._ValorCarta + 1) == novaLista[2]._ValorCarta
                && (novaLista[2]._ValorCarta + 1) == novaLista[3]._ValorCarta
                && (novaLista[3]._ValorCarta + 1) == novaLista[4]._ValorCarta)) ehRealmente = false;

            if (ehRealmente)
            {
                ValorDaMao = DicionarioValores.ValoresMao[EnumTiposMao.Sequencia];
                TipoMao = EnumTiposMao.Sequencia;
            }
        }
        private void VerificarFlusc()
        {
            var itens = MaoCartas.GroupBy(x => x._Naipe).Where(g => g.Count() == 5).ToList();
            
            if (itens.Count == 1)
            {
                ValorDaMao = DicionarioValores.ValoresMao[EnumTiposMao.Flush];
                TipoMao = EnumTiposMao.Flush;
            }
        }
        private void VerificarFullHouse()
        {
            var itens = MaoCartas.GroupBy(x => x._ValorCarta).Where(g => g.Count() == 3).ToList();
            var itens2 = MaoCartas.GroupBy(x => x._ValorCarta).Where(g => g.Count() == 2).ToList();

            if (itens.Count == 1 && itens2.Count == 1)
            {
                ValorDaMao = DicionarioValores.ValoresMao[EnumTiposMao.FullHouse];
                TipoMao = EnumTiposMao.FullHouse;
            }
        }
        private void VerificarQuadra()
        {
            var itens = MaoCartas.GroupBy(x => x._ValorCarta).Where(g => g.Count() == 4).ToList();
            
            if (itens.Count == 1)
            {
                ValorDaMao = DicionarioValores.ValoresMao[EnumTiposMao.Quadra];
                TipoMao = EnumTiposMao.Quadra;
            }

        }
        private void VerificarRoyalFlusch()
        {
            bool ehRealmente = true;
            int naipe = MaoCartas[0]._ValorNaipe;


            foreach (Carta carta in MaoCartas)
            {
                if (carta._ValorNaipe != naipe) return;
            }

            List<Carta> novaLista = new List<Carta>(MaoCartas);

            novaLista = novaLista.OrderBy(x => x._ValorCarta).ToList();

            if (!(novaLista[0]._ValorCarta == 9
                && novaLista[1]._ValorCarta == 10
                && novaLista[2]._ValorCarta == 11
                && novaLista[3]._ValorCarta == 12
                && novaLista[4]._ValorCarta == 13)) ehRealmente = false;

            if (ehRealmente)
            {
                ValorDaMao = DicionarioValores.ValoresMao[EnumTiposMao.RoyalFlush];
                TipoMao = EnumTiposMao.RoyalFlush;
            }

        }
        private void VerificarStraightFlusch()
        {
            bool ehRealmente = true;
            int naipe = MaoCartas[0]._ValorNaipe;


            foreach (Carta carta in MaoCartas)
            {
                if (carta._ValorNaipe != naipe) return;
            }

            List<Carta> novaLista = new List<Carta>(MaoCartas);

            novaLista = novaLista.OrderBy(x => x._ValorCarta).ToList();

            if (!((novaLista[0]._ValorCarta + 1) == novaLista[1]._ValorCarta
                && (novaLista[1]._ValorCarta + 1) == novaLista[2]._ValorCarta
                && (novaLista[2]._ValorCarta + 1) == novaLista[3]._ValorCarta
                && (novaLista[3]._ValorCarta + 1) == novaLista[4]._ValorCarta)) ehRealmente = false;

            if (ehRealmente)
            {
                ValorDaMao = DicionarioValores.ValoresMao[EnumTiposMao.StrainghtFlush];
                TipoMao = EnumTiposMao.StrainghtFlush;
            }

        }
    }
}
