using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker.Dominio.Dominio;
using Poker.Dominio.Dominio.CartadasFinais;
using Poker.Dominio.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Teste.TestesUnidade
{
    [TestClass]
    public class TesteMao
    {

        [TestMethod]
        public void VerificarMaoRoyalFlusc()
        {
            List<Carta> lista = new List<Carta>()
                { new Carta('O', "K"),new Carta('O', "Q"),
                  new Carta('O', "A"),new Carta('O', "J"),new Carta('O',"10")};

            MaoPoker mao = new MaoPoker(lista);

            Assert.AreEqual(mao.TipoMao, EnumTiposMao.RoyalFlush);
        }
        [TestMethod]
        public void VerificarMaoStrainghtFlusc()
        {
            List<Carta> lista = new List<Carta>()
                { new Carta('O', "3"),new Carta('O', "4"),
                  new Carta('O', "5"),new Carta('O', "6"),new Carta('O',"2")};

            MaoPoker mao = new MaoPoker(lista);

            Assert.AreEqual(mao.TipoMao, EnumTiposMao.StrainghtFlush);
        }
        [TestMethod]
        public void VerificarMaoQuadra()
        {
            List<Carta> lista = new List<Carta>()
                { new Carta('O', "4"),new Carta('O', "6"),
                  new Carta('P', "4"),new Carta('E', "4"),new Carta('C',"4")};

            MaoPoker mao = new MaoPoker(lista);

            Assert.AreEqual(mao.TipoMao, EnumTiposMao.Quadra);
        }
        [TestMethod]
        public void VerificarMaoFullHouse()
        {
            List<Carta> lista = new List<Carta>()
                { new Carta('O', "4"),new Carta('O', "6"),
                  new Carta('P', "4"),new Carta('E', "4"),new Carta('C',"6")};

            MaoPoker mao = new MaoPoker(lista);

            Assert.AreEqual(mao.TipoMao, EnumTiposMao.FullHouse);
        }
        [TestMethod]
        public void VerificarMaoFlusc()
        {
            List<Carta> lista = new List<Carta>()
                { new Carta('P', "3"),new Carta('P', "2"),
                  new Carta('P', "10"),new Carta('P', "7"),new Carta('P',"J")};

            MaoPoker mao = new MaoPoker(lista);

            Assert.AreEqual(mao.TipoMao, EnumTiposMao.Flush);
        }
        [TestMethod]
        public void VerificarMaoSequencia()
        {
            List<Carta> lista = new List<Carta>()
                { new Carta('O', "3"),new Carta('C', "2"),
                  new Carta('O', "6"),new Carta('C', "4"),new Carta('P',"5")};

            MaoPoker mao = new MaoPoker(lista);

            Assert.AreEqual(mao.TipoMao, EnumTiposMao.Sequencia);
        }
        [TestMethod]
        public void VerificarMaoTrinca()
        {
            List<Carta> lista = new List<Carta>()
                { new Carta('O', "3"),new Carta('C', "2"),
                  new Carta('O', "6"),new Carta('E', "3"),new Carta('P',"3")};

            MaoPoker mao = new MaoPoker(lista);

            Assert.AreEqual(mao.TipoMao, EnumTiposMao.Trinca);
        }
        [TestMethod]
        public void VerificarMaoDoisPares()
        {
            List<Carta> lista = new List<Carta>()
                { new Carta('O', "3"),new Carta('C', "2"),
                  new Carta('O', "6"),new Carta('E', "3"),new Carta('P',"2")};

            MaoPoker mao = new MaoPoker(lista);

            Assert.AreEqual(mao.TipoMao, EnumTiposMao.DoisPares);
        }
        [TestMethod]
        public void VerificarMaoUmPar()
        {
            List<Carta> lista = new List<Carta>()
                { new Carta('O', "3"),new Carta('C', "2"),
                  new Carta('O', "6"),new Carta('E', "J"),new Carta('P',"2")};

            MaoPoker mao = new MaoPoker(lista);

            Assert.AreEqual(mao.TipoMao, EnumTiposMao.UmPar);
        }
        [TestMethod]
        public void VerificarMaoCartaAlta()
        {
            List<Carta> lista = new List<Carta>()
                { new Carta('O', "5"),new Carta('C', "J"),
                  new Carta('O', "6"),new Carta('E', "K"),new Carta('P',"A")};

            MaoPoker mao = new MaoPoker(lista);

            Assert.AreEqual(mao.TipoMao, EnumTiposMao.CartaAlta);
        }
    }
}
