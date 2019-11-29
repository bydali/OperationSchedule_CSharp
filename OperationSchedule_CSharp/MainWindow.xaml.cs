using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace OperationSchedule_CSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveMap(object sender, RoutedEventArgs e)
        {
            Window window = new SaveMap();
            window.ShowDialog();
        }

        private void SetInterval(object sender, RoutedEventArgs e)
        {
            Window window = new SetInterval();
            window.ShowDialog();
        }

        private void BatchGenaratePlan(object sender, RoutedEventArgs e)
        {
            Window window = new BatchGeneratePlan();
            window.ShowDialog();
        }

        private void GeneratePlan(object sender, RoutedEventArgs e)
        {
            Window window = new GeneratePlan();
            window.ShowDialog();
        }

        private void TransmitCommand(object sender, RoutedEventArgs e)
        {
            Window window = new TransmitCommand();
            window.ShowDialog();
        }

        private void RegularTransmitCommand(object sender, RoutedEventArgs e)
        {
            Window window = new RegularTransmitCommand();
            window.ShowDialog();
        }

        private void ManageTrain(object sender, RoutedEventArgs e)
        {
            Window window = new ManageTrain();
            window.ShowDialog();
        }

        private void ManageCrew(object sender, RoutedEventArgs e)
        {
            Window window = new ManageCrew();
            window.ShowDialog();
        }

        private void ManageAllStock(object sender, RoutedEventArgs e)
        {
            Window window = new ManageAllStock();
            window.ShowDialog();
        }

        private void ManageHanging(object sender, RoutedEventArgs e)
        {
            Window window = new ManageHanging();
            window.ShowDialog();
        }

        private void CountHandOver(object sender, RoutedEventArgs e)
        {
            Window window = new CountHandOver();
            window.ShowDialog();
        }

        private void ReportTime(object sender, RoutedEventArgs e)
        {
            Window window = new ReportTime();
            window.Show();
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            Application.Current.Windows.OfType<ReportTime>().First().Close();
        }

        private void QueryConfirm(object sender, RoutedEventArgs e)
        {
            Window window = new QueryConfirm();
            window.ShowDialog();
        }
    }
}
