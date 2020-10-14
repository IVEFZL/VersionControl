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
using System.Xml;
using Week06.Entities;
using Week06.MnbServiceReference;

namespace Week06
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rates = new BindingList<RateData>();
        DateTime startDate = DateTime.Now.AddDays(-30);
        DateTime endDate = DateTime.Now;
        string currency = "EUR";
        BindingList<string> Currencies = new BindingList<string>();


        public Form1()
        {
            InitializeComponent();
            var mnbService = new MNBArfolyamServiceSoapClient();
            var request = new GetCurrenciesRequestBody();
            var response = mnbService.GetCurrencies(request);
            var result = response.GetCurrenciesResult;
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(result);

            var childElement = (XmlElement)xml.DocumentElement.ChildNodes[0];


            foreach (XmlElement element in childElement)
            {
  
                string currency =element.InnerText;

                Currencies.Add(currency);

            }
            foreach (var item in Currencies)
            {
                comboBox1.Items.Add(item);
            }

            refreshData();
            
        }

        private void refreshData()
        {
            Rates.Clear();
            dataGridView1.DataSource = Rates;
            webServiceCall(currency, startDate, endDate);
            charting();
        }

        private void webServiceCall(string currency, DateTime startDate, DateTime endDate)
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            string start = startDate.ToString();
            string end = endDate.ToString();

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = currency,
                startDate = start,
                endDate = end
            };

            var response = mnbService.GetExchangeRates(request);
            var result = response.GetExchangeRatesResult;

            XmlDocument xml = new XmlDocument();
            xml.LoadXml(result);

            foreach (XmlElement element in xml.DocumentElement)
            {
                
                var rate = new RateData();
                Rates.Add(rate);

                rate.Date = DateTime.Parse(element.GetAttribute("date"));

                var childElement = (XmlElement)element.ChildNodes[0];
                if (childElement == null)
                    continue;
                rate.Currency = childElement.GetAttribute("curr");

                var unit = decimal.Parse(childElement.GetAttribute("unit"));
                var value = decimal.Parse(childElement.InnerText);
                if (unit != 0)
                    rate.Value = value / unit;
            }
        }

        private void charting()
        {
            chartRateData.DataSource = Rates;

            var series = chartRateData.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Date";
            series.YValueMembers = "Value";
            series.BorderWidth = 2;

            var legend = chartRateData.Legends[0];
            legend.Enabled = false;

            var chartArea = chartRateData.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            startDate = dateTimePicker1.Value;
            refreshData();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            endDate = dateTimePicker2.Value;
            refreshData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currency = comboBox1.Text;
            refreshData();
        }
    }
}
