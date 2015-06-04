using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using br.com.tcc.model;

namespace br.com.tcc.bo
{
    public class SprintBO
    {
        public Double calculaTotalHoras(Sprint sprint)
        {

		    Double totalHorasSprint = 0.0;
		    foreach(Estoria est in sprint.getEstorias()) {
			    totalHorasSprint += est.getTempoRestante();
		    }
		
		    return totalHorasSprint;
	    }

        public int calculaTotalPontos(Sprint sprint)
        {

		int totalPontosSprint = 0;
		foreach (Estoria est in sprint.getEstorias()) {
			totalPontosSprint += est.getQtdePontos();
		}
		
		return totalPontosSprint;
	}


    }
}
