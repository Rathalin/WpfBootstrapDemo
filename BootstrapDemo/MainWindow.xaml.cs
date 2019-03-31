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

namespace BootstrapDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TBl_BtnsExample.Text = "<Button Content=\"Primary\" Style=\"{StaticResource btn-primary}\"></Button>" + "\n" +
                "<Button Content=\"Secondary\" Style=\"{StaticResource btn-primary}\"></Button>" + "\n" +
                "<Button Content=\"Success\" Style=\"{StaticResource btn-primary}\"></Button>" + "\n" +
                "<Button Content=\"Danger\" Style=\"{StaticResource btn-primary}\"></Button>" + "\n" +
                "<Button Content=\"Warning\" Style=\"{StaticResource btn-primary}\"></Button>" + "\n" +
                "<Button Content=\"Info\" Style=\"{StaticResource btn-primary}\"></Button>" + "\n" +
                "<Button Content=\"Light\" Style=\"{StaticResource btn-primary}\"></Button>" + "\n" +
                "<Button Content=\"Dark\" Style=\"{StaticResource btn-primary}\"></Button>" + "\n";
            TBl_OutlBtnsExample.Text = "<Button Content=\"Primary\" Style=\"{StaticResource btn-outline-primary}\"></Button>" + "\n" +
                "<Button Content=\"Secondary\" Style=\"{StaticResource btn-outline-primary}\"></Button>" + "\n" +
                "<Button Content=\"Success\" Style=\"{StaticResource btn-outline-primary}\"></Button>" + "\n" +
                "<Button Content=\"Danger\" Style=\"{StaticResource btn-outline-primary}\"></Button>" + "\n" +
                "<Button Content=\"Warning\" Style=\"{StaticResource btn-outline-primary}\"></Button>" + "\n" +
                "<Button Content=\"Info\" Style=\"{StaticResource btn-outline-primary}\"></Button>" + "\n" +
                "<Button Content=\"Light\" Style=\"{StaticResource btn-outline-primary}\"></Button>" + "\n" +
                "<Button Content=\"Dark\" Style=\"{StaticResource btn-outline-primary}\"></Button>" + "\n";
        }
    }
}
