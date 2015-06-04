using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.tcc.model
{
    public class Estoria
    {
        private int codEstoria;
        private double tempoRestante;
        private double tempoGasto = 0;
        private double tempoEstimado;
        private int qtdePontos;

        public double getTempoRestante()
        {
            return tempoRestante;
        }
        public void setTempoRestante(double tempoRestante)
        {
            this.tempoRestante = tempoRestante;
        }
        public double getTempoGasto()
        {
            return tempoGasto;
        }
        public void setTempoGasto(double tempoGasto)
        {
            this.tempoGasto = this.tempoGasto + tempoGasto;
            this.setTempoRestante(getTempoRestante() - tempoGasto);
        }
        public double getTempoEstimado()
        {
            return tempoEstimado;
        }
        public void setTempoEstimado(double estimated)
        {
            this.tempoEstimado = estimated;
            this.tempoRestante = estimated;
        }
        public int getCodEstoria()
        {
            return codEstoria;
        }
        public void setCodEstoria(int codEstoria)
        {
            this.codEstoria = codEstoria;
        }
        public int getQtdePontos()
        {
            return qtdePontos;
        }
        public void setQtdePontos(int qtdePontos)
        {
            this.qtdePontos = qtdePontos;
        }
    }
}
