using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace br.com.tcc.bo
{
    public class LineChart
    {
        String _applicationTitle;
        public void setApplicationTitle(String applicationTitle)
        {
            _applicationTitle = applicationTitle;
        }
        public String getApplicationTitle() { 
            return _applicationTitle;
        }

        String _chartTitle;
        public void setChartTitle(String chartTitle)
        {
            _chartTitle = chartTitle;
        }
        public String getChartTitle()
        {
            return _chartTitle;
        }

        Dictionary<DateTime, int> _grafico;
        public void setGrafico(Dictionary<DateTime, int> grafico)
        {
            _grafico = grafico;
        }
        public Dictionary<DateTime, int> getGrafico()
        {
            return _grafico;
        }

        Double _totalHoras;
        public void setTotalHoras(double totalHoras)
        {
            _totalHoras = totalHoras;
        }
        public Double getTotalHoras() {
            return _totalHoras;
        }

        Double _queimaDiariaIdeal;
        public void setQueimaDiariaIdeal(double queimaDiariaIdeal)
        {
            _queimaDiariaIdeal = queimaDiariaIdeal;
        }
        public Double getQueimaDiariaIdeal()
        {
            return _queimaDiariaIdeal;
        }

        public LineChart(String applicationTitle, String chartTitle, Dictionary<DateTime, int> grafico, Double totalHoras, Double queimaDiariaIdeal) 
        {
            setApplicationTitle(applicationTitle);
            setChartTitle(chartTitle);
            setGrafico(grafico);
            setTotalHoras(totalHoras);
            setQueimaDiariaIdeal(queimaDiariaIdeal);
        }

        //private const long serialVersionUID = 1L;

        //public LineChart(String applicationTitle, String chartTitle, Dictionary<DateTime, Double> grafico, Double totalHoras, Double queimaDiariaIdeal)
        //{

        //    Chart chart = createChart(chartTitle, grafico, totalHoras, queimaDiariaIdeal);

        //    // we put the chart into a panel
        //    ChartPanel chartPanel = new ChartPanel(chart);
        //    // default size

        //    chartPanel.setPreferredSize(new java.awt.Dimension(800, 370));
        //    // add it to our application
        //    setContentPane(chartPanel);
        //}

        //public LineChart(String applicationTitle, String chartTitle, Map<Date, Integer> grafico, Integer totalPontos, Double queimaDiariaIdeal)
        //{

        //    super(applicationTitle);
        //    // based on the dataset we create the chart
        //    JFreeChart chart = createChartPontos(chartTitle, grafico, totalPontos, queimaDiariaIdeal);
        //    // we put the chart into a panel
        //    ChartPanel chartPanel = new ChartPanel(chart);

        //    // default size
        //    chartPanel.setPreferredSize(new java.awt.Dimension(800, 370));
        //    // add it to our application
        //    setContentPane(chartPanel);
        //}

        ////Creates a chart
        //private Chart createChart(String title, Dictionary<DateTime, Double> grafico, Double totalHoras, Double queimaDiariaIdeal) {
	        
        //    Double totalHorasIdeal = totalHoras;
	    	
        //    DefaultCategoryDataset ds = new DefaultCategoryDataset();

        //    //ds.addValue(totalHoras, "real", "0");
        //    //ds.addValue(totalHoras, "ideal", "0");
	    	
        //    for (Date data : grafico.keySet()) {
        //        if (grafico.get(data) != null){
        //            totalHoras = totalHoras - grafico.get(data);
        //            ds.addValue(totalHoras, "real", DataUtil.dateToString(data));
        //        }
        //        else{
        //            ds.addValue(null, "real", DataUtil.dateToString(data));
        //        }
        //        totalHorasIdeal = totalHorasIdeal - queimaDiariaIdeal;
        //        ds.addValue(totalHorasIdeal, "ideal", DataUtil.dateToString(data));
        //    }
        //    JFreeChart chart = ChartFactory.createLineChart(title, "Date", "Remaining Work", ds);

        //    return chart;
        //}

        ////Creates a chart
        //private JFreeChart createChartPontos(String title, Map<Date, Integer> grafico, Integer totalPontos, Double queimaDiariaIdeal) {
	        
        //    Integer totalPontosIdeal = totalPontos;
	    	
        //    DefaultCategoryDataset ds = new DefaultCategoryDataset();
        //    //ds.addValue(totalHoras, "real", "0");
        //    //ds.addValue(totalHoras, "ideal", "0");
	    	
        //    for (Date data : grafico.keySet()) {
        //        if (grafico.get(data) != null){
        //            totalPontos = totalPontos - grafico.get(data);
        //            ds.addValue(totalPontos, "real", DataUtil.dateToString(data));
        //        }
        //        else{
        //            ds.addValue(null, "real", DataUtil.dateToString(data));
        //        }
        //        totalPontosIdeal = totalPontosIdeal - queimaDiariaIdeal.intValue();
        //        ds.addValue(totalPontosIdeal, "ideal", DataUtil.dateToString(data));
        //    }
        //    JFreeChart chart = ChartFactory.createLineChart(title, "Date", "Remaining Work", ds);

        //    return chart;
        //}
    }
}
