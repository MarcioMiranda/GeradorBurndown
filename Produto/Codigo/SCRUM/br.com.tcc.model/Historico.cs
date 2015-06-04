using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.tcc.model
{
    public class Historico
    {
        private List<ItemHistorico> itens;

        public List<ItemHistorico> getItens()
        {
            return itens;
        }

        public void setItens(List<ItemHistorico> itens)
        {
            this.itens = itens;
        }
    }
}
