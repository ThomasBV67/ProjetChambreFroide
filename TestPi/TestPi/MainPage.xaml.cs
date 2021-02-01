using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using WinRTXamlToolkit.Controls.DataVisualization.Charting;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TestPi
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public class NameValueItem
        {
            public string Name { get; set; }
            public int Value { get; set; }
        }
        DateTime time = new DateTime();
        Random _random = new Random();

        public MainPage()
        {
            this.InitializeComponent();


            // Prepare items for Series[0] which is "T1"
            List<NameValueItem> items1 = new List<NameValueItem>();
            items1.Add(new NameValueItem { Name = "Test1", Value = _random.Next(10, 100) });
            items1.Add(new NameValueItem { Name = "Test2", Value = _random.Next(10, 200) });
            items1.Add(new NameValueItem { Name = "Test3", Value = _random.Next(10, 300) });
            items1.Add(new NameValueItem { Name = "Test4", Value = _random.Next(10, 400) });
            items1.Add(new NameValueItem { Name = "Test5", Value = _random.Next(10, 500) });

            // Prepare items for Series[1] which is "T2"
            List<NameValueItem> items2 = new List<NameValueItem>();
            items2 = new List<NameValueItem>();
            items2.Add(new NameValueItem { Name = "Test1", Value = _random.Next(100, 100) });
            items2.Add(new NameValueItem { Name = "Test2", Value = _random.Next(100, 200) });
            items2.Add(new NameValueItem { Name = "Test3", Value = _random.Next(100, 300) });
            items2.Add(new NameValueItem { Name = "Test4", Value = _random.Next(100, 400) });
            items2.Add(new NameValueItem { Name = "Test5", Value = _random.Next(100, 500) });

            // Supply items to the series
            ((LineSeries)this.LineChart1.Series[0]).ItemsSource = items1;
            ((LineSeries)this.LineChart1.Series[1]).ItemsSource = items2;

            // [OPTIONAL] Change Y-Axis range from 0 to 1000 with interval of 250 of Series[0]
            ((LineSeries)this.LineChart1.Series[0]).DependentRangeAxis =
               new LinearAxis
               {
                   Minimum = 0,
                   Maximum = 1000,
                   Orientation = AxisOrientation.Y,
                   Interval = 250,
                   ShowGridLines = true
               };

            // [OPTIONL] Change Y-Axis range from 0 to 1000 with interval of 250 of Series[1]
            ((LineSeries)this.LineChart1.Series[1]).DependentRangeAxis =
               new LinearAxis
               {
                   Minimum = 0,
                   Maximum = 1000,
                   Orientation = AxisOrientation.Y,
                   Interval = 250,
                   ShowGridLines = true
               };
        }

    }
}
