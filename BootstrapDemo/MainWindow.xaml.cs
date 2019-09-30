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
            TBl_AlertsExample.Text = "<Border Style=\"{StaticResource border-alert-primary}>" + "\n" +
                "\t" + "<TextBlock Style=\"{StaticResource textbox-alert-primary}\" Text=\"Alert primary\"></TextBlock>" + "\n" +
                "</Border>" + "\n" +
                "<Border Style=\"{StaticResource border-alert-secondary}>" + "\n" +
                "\t" + "<TextBlock Style=\"{StaticResource textbox-alert-secondary}\" Text=\"Alert secondary\"></TextBlock>" + "\n" +
                "</Border>" + "\n" +
                "<Border Style=\"{StaticResource border-alert-success}>" + "\n" +
                "\t" + "<TextBlock Style=\"{StaticResource textbox-alert-success}\" Text=\"Alert success\"></TextBlock>" + "\n" +
                "</Border>" + "\n" +
                "<Border Style=\"{StaticResource border-alert-danger}>" + "\n" +
                "\t" + "<TextBlock Style=\"{StaticResource textbox-alert-danger}\" Text=\"Alert danger\"></TextBlock>" + "\n" +
                "</Border>" + "\n" +
                "<Border Style=\"{StaticResource border-alert-warning}>" + "\n" +
                "\t" + "<TextBlock Style=\"{StaticResource textbox-alert-warning}\" Text=\"Alert warning\"></TextBlock>" + "\n" +
                "</Border>" + "\n" +
                "<Border Style=\"{StaticResource border-alert-info}>" + "\n" +
                "\t" + "<TextBlock Style=\"{StaticResource textbox-alert-info}\" Text=\"Alert info\"></TextBlock>" + "\n" +
                "</Border>" + "\n" +
                "<Border Style=\"{StaticResource border-alert-light}>" + "\n" +
                "\t" + "<TextBlock Style=\"{StaticResource textbox-alert-light}\" Text=\"Alert light\"></TextBlock>" + "\n" +
                "</Border>" + "\n" +
                "<Border Style=\"{StaticResource border-alert-dark}>" + "\n" +
                "\t" + "<TextBlock Style=\"{StaticResource textbox-alert-dark}\" Text=\"Alert dark\"></TextBlock>" + "\n" +
                "</Border>" + "\n";

            /*
                
                <Border Style="{StaticResource border-alert-danger}" Margin="0 5 0 0" Grid.ColumnSpan="8" Grid.Row="9">
                    <TextBlock Style="{StaticResource textbox-alert-danger}" Text="Alert danger"></TextBlock>
                </Border>
                <Border Style="{StaticResource border-alert-warning}" Margin="0 5 0 0" Grid.ColumnSpan="8" Grid.Row="10">
                    <TextBlock Style="{StaticResource textbox-alert-warning}" Text="Alert warning"></TextBlock>
                </Border>
                <Border Style="{StaticResource border-alert-info}" Margin="0 5 0 0" Grid.ColumnSpan="8" Grid.Row="11">
                    <TextBlock Style="{StaticResource textbox-alert-info}" Text="Alert info"></TextBlock>
                </Border>
                <Border Style="{StaticResource border-alert-light}" Margin="0 5 0 0" Grid.ColumnSpan="8" Grid.Row="12">
                    <TextBlock Style="{StaticResource textbox-alert-light}" Text="Alert light"></TextBlock>
                </Border>
                <Border Style="{StaticResource border-alert-dark}" Margin="0 5 0 0" Grid.ColumnSpan="8" Grid.Row="13">
                    <TextBlock Style="{StaticResource textbox-alert-dark}" Text="Alert dark"></TextBlock>
                </Border>
                */
        }
    }
}
