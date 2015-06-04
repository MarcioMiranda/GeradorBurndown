using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using br.com.tcc.model;
using br.com.tcc.bo;

namespace SCRUM.Teste
{
    /// <summary>
    /// Summary description for TestSprint
    /// </summary>
    [TestClass]
    public class TestSprint
    {
        public TestSprint()
        {
            //
            // TODO: Add constructor logic here
            //

            _sprint = criarSprint();

            burndown = new BurndownBO();

        }

        Sprint _sprint;
        BurndownBO burndown;

        DateTime _dataInicio = DateTime.Parse("04/05/2015");
        int _qteDias = 7;
        SprintBO _sprintBO = new SprintBO();

        Sprint criarSprint()
        {

            Sprint _s = new Sprint();

            _s.setDtFim(_dataInicio);
            _s.setQtdeDias(_qteDias);
            _s.setEstorias(criaListaEstorias());

            _s.setTotalHoras(_sprintBO.calculaTotalHoras(_s));
            _s.setItensHistorico(criaItensHistorico());

            return _s;
        }

        List<ItemHistorico> criaItensHistorico()
        {

            ItemHistorico item = new ItemHistorico();
            item.setCodEstoria(1);
            item.setTempoGasto(34);
            item.setData(_dataInicio);

            ItemHistorico item2 = new ItemHistorico();
            item2.setCodEstoria(2);
            item2.setTempoGasto(18);
            item2.setData(_dataInicio.AddDays(1));

            ItemHistorico item3 = new ItemHistorico();
            item3.setCodEstoria(3);
            item3.setTempoGasto(15);
            item3.setData(_dataInicio.AddDays(2));

            ItemHistorico item4 = new ItemHistorico();
            item4.setCodEstoria(3);
            item4.setTempoGasto(33);
            item4.setData(_dataInicio.AddDays(3));

            ItemHistorico item5 = new ItemHistorico();
            item5.setCodEstoria(3);
            item5.setTempoGasto(3);
            item5.setData(_dataInicio.AddDays(4));

            ItemHistorico item6 = new ItemHistorico();
            item6.setCodEstoria(3);
            item6.setTempoGasto(2);
            item6.setData(_dataInicio.AddDays(5));

            ItemHistorico item7 = new ItemHistorico();
            item7.setCodEstoria(1);
            item7.setTempoGasto(6);
            item7.setData(_dataInicio.AddDays(6));

            return new List<ItemHistorico>() { item, item2, item3, item4, item5, item6, item7 };
        }

        List<Estoria> criaListaEstorias()
        {

            Estoria est1 = new Estoria();
            est1.setTempoEstimado(40);
            est1.setCodEstoria(1);
            est1.setQtdePontos(5);

            Estoria est2 = new Estoria();
            est2.setTempoEstimado(32);
            est2.setCodEstoria(2);
            est2.setQtdePontos(3);

            Estoria est3 = new Estoria();
            est3.setTempoEstimado(10);
            est3.setCodEstoria(3);
            est3.setQtdePontos(1);

            Estoria est4 = new Estoria();
            est4.setTempoEstimado(88);
            est4.setCodEstoria(4);
            est4.setQtdePontos(8);

            return new List<Estoria>() { est1, est2, est3, est4 };
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion




        [TestMethod]
        public void TestTotalHorasSprints_Ok()
        {
            Assert.AreEqual(burndown.gerarBurndownHoras(_sprint).getTotalHoras(), 170);
        }

        [TestMethod]
        public void TestTotalHorasSprints_Erro()
        {
            Assert.AreEqual(burndown.gerarBurndownHoras(_sprint).getTotalHoras(), 150);
        }

        [TestMethod]
        public void TestHorasConsumidasSprints_Ok()
        {
            int _qteHorasConsumidas = 0;

            foreach(ItemHistorico item in _sprint.getItensHistorico()){
                _qteHorasConsumidas += item.getTempoGasto();
            }

            Assert.AreEqual(_qteHorasConsumidas, 111);
        }

        [TestMethod]
        public void TestHorasConsumidasSprints_Erro()
        {
            int _qteHorasConsumidas = 0;

            foreach (ItemHistorico item in _sprint.getItensHistorico())
            {
                _qteHorasConsumidas += item.getTempoGasto();
            }

            Assert.AreEqual(_qteHorasConsumidas, 110);
        }

        [TestMethod]
        public void TestTotalPontosSprints_Erro()
        {
            Assert.AreEqual(burndown.gerarBurndownPontos(_sprint).getTotalHoras(), 15);

        }

        [TestMethod]
        public void TestTotalPontosSprints_Ok()
        {
            Assert.AreEqual(burndown.gerarBurndownPontos(_sprint).getTotalHoras(), 17);

        }
    }
}
