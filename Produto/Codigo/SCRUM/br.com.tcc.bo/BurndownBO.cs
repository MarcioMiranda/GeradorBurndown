using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using br.com.tcc.model;
using br.com.tcc.util;

namespace br.com.tcc.bo
{
    public class BurndownBO
    {
	    private double qtdeHorasConsumidas;
	    private double qtdeHorasRestantes;
	    private double totalHoras;
	    private double consumoDiarioIdeal;
	    private const String TITLE_HORAS = "HOUR BURNDOWN CHART- Sprint 01";
	    private const String TITLE_PONTOS = "POINT BURNDOWN CHART- Sprint 01";

        

        Sprint _sprint;

        public LineChart gerarBurndownHoras(Sprint sprint)
        {

            Dictionary<DateTime, int> eixoXY = calculaEixosXYHoras(sprint);
		    setTotalHoras(sprint.getTotalHoras());
		
		    qtdeHorasRestantes = totalHoras - qtdeHorasConsumidas;
		
		    setConsumoDiarioIdeal(totalHoras / sprint.getQtdeDias());
		
		    //LineChart demo = new LineChart("Comparison", TITLE_HORAS, eixoXY, totalHoras, consumoDiarioIdeal);
            //demo.pack();
            //demo.setVisible(true);

            return new LineChart("Comparison", TITLE_HORAS, eixoXY, totalHoras, consumoDiarioIdeal);

	    }

        public LineChart gerarBurndownPontos(Sprint sprint)
        {

            int totalPontos = 0;

            foreach (Estoria estoria in sprint.getEstorias())
            {
                totalPontos += estoria.getQtdePontos();
            }

            Dictionary<DateTime, int> eixoXY = eixoXYPontos(sprint);

            setConsumoDiarioIdeal(totalHoras / sprint.getQtdeDias());

            //LineChart demo = new LineChart("Comparison", TITLE_PONTOS, eixoXY, totalPontos, consumoDiarioIdeal);
            //demo.pack();
            //demo.setVisible(true);

            return new LineChart("Comparison", TITLE_PONTOS, eixoXY, totalPontos, consumoDiarioIdeal);

        }


        private Dictionary<DateTime, int> calculaEixosXYHoras(Sprint sprint)
        {

            Dictionary<DateTime, int> eixoXY = new Dictionary<DateTime, int>();

            //eixoY
            foreach (ItemHistorico item in sprint.getItensHistorico())
            {
                if (eixoXY.ContainsKey(item.getData()))
                {
                    eixoXY[item.getData()] = eixoXY[item.getData()] + item.getTempoGasto();
                }
                else
                {
                    eixoXY.Add(item.getData(), item.getTempoGasto());
                }
                qtdeHorasConsumidas += item.getTempoGasto();
            }

            //Dias ainda nÃ£o trabalhados
            if (eixoXY.Count() < sprint.getQtdeDias())
            {
                for (int i = 0; i < sprint.getQtdeDias(); i++)
                {
                    if (!eixoXY.ContainsKey(DataUtil.adicionarDiasData(sprint.getDtInicio(), i)))
                    {
                        eixoXY.Add(DataUtil.adicionarDiasData(sprint.getDtInicio(), i), 0);
                    }
                }
            }

            return eixoXY;
        }

        private Dictionary<DateTime, int> eixoXYPontos(Sprint sprint)
        {

            Dictionary<DateTime, int> eixoXY = new Dictionary<DateTime, int>();

            //eixoY
            foreach (ItemHistorico item in sprint.getItensHistorico())
            {
                foreach (Estoria detalhe in (from e in sprint.getEstorias() where e.getCodEstoria().Equals(item.getCodEstoria()) select e))
                {
                    Estoria _novaEstoria = detalhe;

                    _novaEstoria.setTempoGasto(item.getTempoGasto());

                    if (_novaEstoria.getTempoRestante() == 0)
                    {
                        if (eixoXY.ContainsKey(item.getData()))
                        {                            
                            eixoXY[item.getData()] = eixoXY[item.getData()] + _novaEstoria.getQtdePontos();
                        }
                        else {
                            eixoXY.Add(item.getData(), _novaEstoria.getQtdePontos());
                        }
                    }
                }
            }

            return eixoXY;
	    }
	
	    public double getQtdeHorasRestantes() {
		    return qtdeHorasRestantes;
	    }

	    public void setQtdeHorasRestantes(double qtdeHorasRestantes) {
		    this.qtdeHorasRestantes = qtdeHorasRestantes;
	    }

	    public double getTotalHoras() {
		    return totalHoras;
	    }

	    public void setTotalHoras(double totalHoras) {
		    this.totalHoras = totalHoras;
	    }

	    public double getQtdeHorasConsumidas() {
		    return qtdeHorasConsumidas;
	    }

	    public void setQtdeHorasConsumidas(double qtdeHorasConsumidas) {
		    this.qtdeHorasConsumidas = qtdeHorasConsumidas;
	    }

	    public double getConsumoDiarioIdeal() {
		    return consumoDiarioIdeal;
	    }

        public void setConsumoDiarioIdeal(double consumoDiarioIdeal)
        {
            this.consumoDiarioIdeal = consumoDiarioIdeal;
        }


        public string getTitleHoras() {
            return TITLE_HORAS;
        }

        public Sprint GetSprint(){
            return _sprint;
        }


    }
}
