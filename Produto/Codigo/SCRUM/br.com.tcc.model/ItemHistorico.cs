using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.tcc.model
{
    public class ItemHistorico
    {
        private int codEstoria;
        private DateTime data;
        private int tempoGasto;

        public DateTime getData()
        {
            return data;
        }
        public void setData(DateTime data)
        {
            this.data = data;
        }
        public int getTempoGasto()
        {
            return tempoGasto;
        }
        public void setTempoGasto(int tempoGasto)
        {
            this.tempoGasto = tempoGasto;
        }
        public int getCodEstoria()
        {
            return codEstoria;
        }
        public void setCodEstoria(int codEstoria)
        {
            this.codEstoria = codEstoria;
        }
    }
}
