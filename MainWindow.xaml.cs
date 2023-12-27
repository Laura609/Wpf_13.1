using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Text.Json;
using Wpf_13._1.Core;

namespace Wpf_13._1
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();


        }

        private void AppDate_Click(object sender, RoutedEventArgs e)
        {

            var appDataService = new AppDataService("appData.json");

            // Сохранение данных
            var data = new Json
            {
                Data1 = "Hello, World!",
                Data2 = 42
            };
            appDataService.Save(data);

            // Загрузка данных
            var loadedData = appDataService.Load();

            MessageBox.Show($"{data}");
        }
    }
}