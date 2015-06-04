using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using br.com.tcc.bo;
using br.com.tcc.model;

namespace SCRUM.UI.dsk
{
    public partial class frmBurndownHoras : Form
    {

        LineChart _lineChat;

        public frmBurndownHoras(LineChart lineChat)
        {
            InitializeComponent();

            _lineChat = lineChat;       
        }

        private void frmBurndownHoras_Load(object sender, EventArgs e)
        {                     
            grafBurndownHoras.Series.Clear();

            grafBurndownHoras.Series.Add("Horas Consumidas");
            grafBurndownHoras.Series.Add("Horas Restantes");

            Double _qteHorasRestantes = _lineChat.getTotalHoras();
            Double _horasConsumidas = 0;

            foreach (KeyValuePair<DateTime, int> item in _lineChat.getGrafico())
            {
                _horasConsumidas += item.Value;
                
                grafBurndownHoras.Series[0].Points.Add(new DataPoint(item.Key.ToOADate(), _horasConsumidas));                
                grafBurndownHoras.Series[1].Points.Add(new DataPoint(item.Key.ToOADate(), _qteHorasRestantes));

                _qteHorasRestantes -= item.Value;                                
            }

            grafBurndownHoras.Series[0].IsValueShownAsLabel = true;
            grafBurndownHoras.Series[0].XValueType = ChartValueType.Date;
            grafBurndownHoras.Series[0].ChartType = SeriesChartType.FastLine;
            grafBurndownHoras.Series[0].Color = Color.Red;

            grafBurndownHoras.Series[1].IsValueShownAsLabel = true;
            grafBurndownHoras.Series[1].XValueType = ChartValueType.Double;
            grafBurndownHoras.Series[1].ChartType = SeriesChartType.FastLine;
            grafBurndownHoras.Series[1].Color = Color.Blue;

        }
    }
}
