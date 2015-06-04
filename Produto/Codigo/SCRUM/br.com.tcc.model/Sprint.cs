using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.tcc.model
{
    public class Sprint
    {
        private DateTime dtInicio;
        public DateTime getDtInicio()
        {
            return dtInicio;
        }
        public void setDtInicio(DateTime dtInicio)
        {
            this.dtInicio = dtInicio;
        }

        private DateTime dtFim;
        public DateTime getDtFim()
        {
            return dtFim;
        }
        public void setDtFim(DateTime dtFim)
        {

            this.dtFim = dtFim;
        }

        private List<Estoria> estorias;
        public List<Estoria> getEstorias()
        {
            return estorias;
        }
        public void setEstorias(List<Estoria> estorias)
        {

            this.estorias = estorias;
        }

        private Double totalHoras;
        public Double getTotalHoras()
        {
            return totalHoras;
        }
        public void setTotalHoras(Double totalHoras)
        {
            this.totalHoras = totalHoras;
        }

        private int qtdeDias;
        public int getQtdeDias()
        {
            return qtdeDias;
        }
        public void setQtdeDias(int qtdeDias)
        {
            this.qtdeDias = qtdeDias;
        }

        private List<ItemHistorico> itensHistorico;
        public List<ItemHistorico> getItensHistorico()
        {
            return itensHistorico;
        }
        public void setItensHistorico(List<ItemHistorico> itensHistorico)
        {
            this.itensHistorico = itensHistorico;
        }
    }
}
