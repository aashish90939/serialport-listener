using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot.WindowsForms;
using OxyPlot;
using OxyPlot.Legends;
using OxyPlot.Series;
using OxyPlot.Annotations;
using OxyPlot.Axes;
using static ReadFromserial3.Form1;


namespace ReadFromserial3
{
    public partial class Form2 :Form
    {
        public OxyPlot.WindowsForms.PlotView plot;

        private PlotModel plotModel;
        public PlotModel PlotModel
        {
            get { return plotModel; }
            set { plotModel = value; OnPropertyChanged("PlotModel"); }
        }

        private DateTime lastUpdate = DateTime.Now;

        public Form2()
        {
            plot = new OxyPlot.WindowsForms.PlotView();
            this.InitializeComponent();
            PlotModel  = new PlotModel();
            plot.Model = PlotModel;
            this.Controls.Add(plot);
            plot.Dock=DockStyle.Fill;
            plot.Location = new System.Drawing.Point(10, 70);
            
            SetUpModel();
            LoadData();
            UpdateModel();
           


        }

        private readonly List<OxyColor> colors = new List<OxyColor>
                                            {
                                                OxyColors.Green,
                                                OxyColors.IndianRed,
                                                OxyColors.Coral,
                                                OxyColors.Chartreuse,
                                                OxyColors.Azure
                                            };

        private readonly List<MarkerType> markerTypes = new List<MarkerType>
                                                   {
                                                       MarkerType.Plus,
                                                       MarkerType.Star,
                                                       MarkerType.Diamond,
                                                       MarkerType.Triangle,
                                                       MarkerType.Cross
                                                   };


        private void SetUpModel()
        {
            PlotModel.Legends.Add(new Legend
            {
                LegendTitle = "Sensor Data",
                LegendOrientation = LegendOrientation.Horizontal,
                LegendPlacement = LegendPlacement.Outside,
                LegendPosition = LegendPosition.LeftBottom,
                LegendBackground = OxyColor.FromAColor(200, OxyColors.White),
                LegendBorder = OxyColors.DarkRed
            }) ;
            var dateAxis = new DateTimeAxis { Position = AxisPosition.Bottom, MajorStep = 25,IntervalLength=50, Title = "Time", StringFormat = "MM:dd", MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot };
            var valueAxis = new LinearAxis{ Position= AxisPosition.Left,MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot, Title = "Value" };
            PlotModel.Axes.Add(dateAxis);
            PlotModel.Axes.Add(valueAxis);

            
        }

        private void LoadData()
        {
            //PlotModel.Series.Add(new FunctionSeries(Math.Sin, 0, 10, 0.1, "sin(x)"));
            //PlotModel.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.2, "Cos(x)"));
            List<Measurement> measurements = Form1.GetData();
            var dataPerSensor = measurements.GroupBy(m => m.SensorId).OrderBy(m => m.Key).ToList();
            foreach (var data in dataPerSensor)
            {
                var lineserie = new LineSeries
                {
                    StrokeThickness = 2,
                    MarkerSize = 3,
                    //MarkerStroke = colors[data.Key],
                    //MarkerType = markerTypes[data.Key],
                    CanTrackerInterpolatePoints = false,
                    Title = string.Format("Sensor {0}", data.Key),
                    //Smooth = True,
                };
                data.ToList().ForEach(d => lineserie.Points.Add(new DataPoint(DateTimeAxis.ToDouble(d.DateTime), d.value)));
                PlotModel.Series.Add(lineserie);
            }
            //import data from form 1.............
            lastUpdate = DateTime.Now;

            //throw new NotImplementedException();
        }
        public void UpdateModel()
        {
            
            List<Measurement> measurements = Form1.GetUpdateData(lastUpdate);
            var dataPerSensor = measurements.GroupBy(m => m.SensorId).OrderBy(m => m.Key).ToList();

            foreach (var data in dataPerSensor)
            {
                var lineserie = PlotModel.Series[data.Key] as LineSeries;
                if (lineserie != null)
                {
                    data.ToList()
                        .ForEach(d => lineserie.Points.Add(new DataPoint(DateTimeAxis.ToDouble(d.DateTime), d.value)));
                }
            }
            lastUpdate = DateTime.Now;
        }

            private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

      
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private void btnStartmonitor_Click(object sender, EventArgs e)
        {
           
    }

        private void btnStopmonitor_Click(object sender, EventArgs e)
        {

        }
    }
}
