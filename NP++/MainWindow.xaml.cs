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
using NP__.Operation;

namespace NP__
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenSave fl = new OpenSave();
            string write = fl.OF();
            writableBox.Text =write + "";
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenSave fl = new OpenSave();
            fl.SF(writableBox.Text);
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            writableBox.Clear();
        }
    }
}
