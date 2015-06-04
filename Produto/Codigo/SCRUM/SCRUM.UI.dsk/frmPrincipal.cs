using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using br.com.tcc.bo;
using br.com.tcc.model;

namespace SCRUM.UI.dsk
{
    public partial class frmPrincipal : Form
    {
        static DateTime _dataInicio = DateTime.Parse("04/05/2015");
        static int _qteDias = 7;
        SprintBO _sprintBO = new SprintBO();
        
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnGerarGrafico_Click(object sender, EventArgs e)
        {
            Sprint _sprint = criarSprint();

            BurndownBO burndown = new BurndownBO();

            burndown.gerarBurndownPontos(_sprint);

            new frmBurndownHoras(burndown.gerarBurndownHoras(_sprint)).ShowDialog();

            this.Hide();
        }

        Sprint criarSprint() {

            Sprint _s = new Sprint();

            _s.setDtFim(_dataInicio);
            _s.setQtdeDias(_qteDias);
            _s.setEstorias(criaListaEstorias());

            _s.setTotalHoras(_sprintBO.calculaTotalHoras(_s));
            _s.setItensHistorico(criaItensHistorico());

            return _s;
        }

        List<ItemHistorico> criaItensHistorico() {

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

        List<Estoria> criaListaEstorias() {

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

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            btnGerarGrafico_Click(sender, e);
        }
    }
}
